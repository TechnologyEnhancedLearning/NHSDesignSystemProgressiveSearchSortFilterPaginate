# NHS Design System Search, Sort, Filter and Paginate
A reusable, progressively enhanced implementation of search, sort, filter and paginate for lists of items.

## Introduction
Many parts of the DLS interface include lists of records (usually displayed as cards). There is usually a requirement to implement some or all of the following for these:

- Search

- Sort

- Filter

- Paginate

This package implements standard, reusable approaches to these with a non-JS and progressively enhanced JS implementation.

## JS and Non-JS approaches
JS browser side search/sort/paginate looks for class ‘searchable-element’ and the logic for getting all the data for it no longer has a fixed /LearningPortal/endpoint

Non-js has Generic version of the 2 helpers whose methods work for any class where the class extends BaseSearchableItem. The view model for the search page should extend BaseSearchablePageViewModel (this contains things like the items per page and ascending/descending string constants and pagination functions)

### GenericSortingHelper:

- Takes a comma separated list of property names to sort on and a direction

- Comma separated list is for OrderBy.ThenBy style ordering

- Rather than dealing with the strings used for switch statements, the SortBy options dropdown is instead populated from a List<(string, string)> containing the display string for the UI and the comma separated property names. The existing ones are defined in this file, but regular property names being input should just work fine

This relies on new QueryableExtensions defined to be able to take a string property name to order on rather than the conventional lambda expression. Currently only OrderBy and ThenBy variants are defined, but I expect we might need some similar variants for Where functionality for filters.

### GenericSearchHelper:

- Less changes here, just combined the two version from before using optional parameters, but since we have the common BaseSearchableItem, we can search any item that extends that using whatever values that type defines as the searchable string - e.g. Users could be searched by ‘FirstName LastName’

## JS search, sort, filter and paginate
### Setup
- A set of typescript files for each function + the wrapper SearchSortAndPaginate

- Each page that uses the javascript search sets up a new instance of SearchSortAndPaginate with the endpoint needed to get the elements we are searching. The endpoint passed in should be the full relative path without the initial / e.g. TrackingSystem/Centre/Administrators/AllAdmins

#### SearchSortAndPaginate

- Sets up the functions by getting all the data as html from an endpoint and mapping it into SearchableElement objects. This mapping puts the the whole html element with class ‘searchable-element’ and a title from the span with class 'searchable-element-title'.

interface SearchableElement { element: Element; title: string;}

- Calls the respective functions to set up the event listeners on the search box/sort dropdowns

- Filter

 - This relies on a hidden input id ‘filter-by’ which contains the full filter string

 - On change of the selector dropdown different filter dropdowns are shown/hidden

 - On clicking the apply filter button, the new filter string is appended to the hidden filter-by input and the change event for it is fired

 - When the on change event fires, the SearchSortAndPaginate method is run, doing all the search/sort/filter/paginate. The filter part of this takes the string filter, breaks it down into the individual filters then loops through the SeachableElements filtering them on whether they contain an element with a 'data-filter-value' attribute that matches the filter. We then flatten the resulting filtered lists of elements using lodash and take all the unique values from this list. This resulting filtered list is then passed into the search method

 - The clear filters button empties the filter-by input and fires the change event.

 - Applied filter tags are included in the all searchable elements html and are pulled out into a separate list of elements. When we have filters in the filter-by, we iterate over those to find the matching tag from all the possible tags and append it to the applied-filter-container

- Search

 - Search box is an input with id ‘search-field’

 - On change in the search box:

   - A new instance of the JsSearch.Search is set up, which searches through the title properties of our SearchableElements

The SearchableElements that match are then passed through the sort and paginate functions before inserting all the element properties into the results container to display

- Sort

 - The sort by dropdown is an input with id ‘select-sort-by’. The order by dropdown has id ‘select-sort-direction’

 - On change of either of these dropdowns:

  - We get the string value to sort by and the direction from the dropdowns

  - We get html element value to order by from the string value. This is defined in a large switch statement to get different elements by name property. e.g. if we are trying to order by a completed date, we order the list of SearchableElements by the text in the html element with name=”completed-date”

  - The SearchableElements that match are then passed through the paginate function before inserting all the element properties into the results container to display

- Paginate

 - The pagination buttons have id 'nhsuk-pagination__link--prev' and 'nhsuk-pagination__link--next'

 - On change of page, we take the next/previous set of items from the whole current searched/sorted list

## No-JS search, sort, filter and paginate
### General setup:
See the AdministratorController or e.g. Completed.cs partial of LearningPortalController in https://github.com/TechnologyEnhancedLearning/DLSV2 for an example.

### Web project
- Make the view model for the page implement BaseSearchablePageViewModel. This contains the basic set of fields/properties needed for the search/sort/filters to work and is the type needed for the various view components and partials that make up the functionality. All of the pagination functionality is here.

- The constructor of this view model should take an IEnumerable of a database entity that implements BaseSearchableItem, a search string, a sort by string, a sort direction string, a filter string and a page number. It should then call the following

 - GenericSearchHelper to filter the input items by the search string

 - FilteringHelper to filter the searched items by the applied filters string

 - GenericSortingHelper to sort the filtered items by the sort property

 - The pagination methods defined on the base model

- The list of entities to be searched over should be defined in a partial containing an NHS expander with a view model that implements BaseFilterableViewModel. This base view model contains the tags that can be filtered on and is the type needed for the FilterableTags view component. Note that this partial should be set up in a suitable way for the JavaScript version to work.

- If the page has a side nav, we should use one of the partials contained in the folder /Views/Shared/SearchablePage/Configurations for 3/4 width. If the page does not have a side nav, we should use one of the full width ones. The difference between these is the layout of the Search and Sort components. In Full Width they are next to each other, in 3/4 Width they are above/below each other.

### Data project
Make the database result entities to be searched over implement BaseSearchableItem, defining the search property to be made up of whatever string properties to search over. All the helpers used take an IQueryable<T> where T implements BaseSearchableItem.  e.g. for User (used for the Admin search) we can search over ‘FirstName LastName’.

```
public override string SearchableName

{

    get => SearchableNameOverrideForFuzzySharp ?? $"{FirstName} {LastName}";

    set => SearchableNameOverrideForFuzzySharp = value;

}
```
  
### Search specific details
- GenericSearchHelper uses FuzzySharp’s fuzzy string matching to search over the SearchableName property of the database entities that implement BaseSearchableItem.

### Sorting specific details
- GenericSortingHelper uses a set of IQueryable extensions that allow ordering by a string property name.

- Sort options are defined as static tuples (string DisplayText, string PropertyName) in the GenericSortingHelper file. The DisplayText is the user friendly text to be displayed in the sort dropdown (if necessary) and the PropertyName is a comma separated list of properties of the database entity to order by.

- Override BaseSearchablePageViewModel.SortOptions with the list of sort options to be used on this page.

### Filtering specific details
- Filters are defined as a IEnumerable of FilterViewModels on the BaseSearchablePageViewModel

- Each FilterViewModel contains a list of FilterOptionViewModel which contain the information needed for the filter dropdowns and any tags we need to display on the expander cards.

- Each filter option is made up of:

 - DisplayName string - the user friendly string to display in the dropdown. e.g. “Centre administrator”
 - Filter string - a grouping, a property name and the value of it separated by pipes | e.g. “Role|IsCentreAdmin|true”
 - TagStatus FilterStatus(enum) - This links the filterable option to a tag colour to be used when displaying filterable tags on the card depending on whether it is a Warning, Success or Default
 - The whole set of applied filters is contained in a ╡ separated string of the filter strings. This is not a newline separator like we use elsewhere because the typescript test would not handle it correctly.
- FilteringHelper divides up this filter string and uses a new IQueryable extension that allows Where  equality using string values e.g.

  `admins.Where("IsCentreAdmin", "true")`

- This means that if the filter needs to check multiple properties of the entity or the check would normally use an inequality, then a new property should be defined on the entity to handle this check e.g. for admins the following have been defined.

`public bool IsLocked => FailedLoginCount >= FailedLoginThreshold; (5)`

`public bool IsCmsAdministrator => ImportOnly && IsContentManager;`

- Clearing the filter is done by submitting the string ‘CLEAR’ as the filterBy parameter. If there is also a filterValue parameter this will be added to the newly cleared filterBy resulting in a single filter being applied. This should only occur if the query string has manually be altered to send the CLEAR, the the component with the Clear Filters button should only send the CLEAR with no filter value.
