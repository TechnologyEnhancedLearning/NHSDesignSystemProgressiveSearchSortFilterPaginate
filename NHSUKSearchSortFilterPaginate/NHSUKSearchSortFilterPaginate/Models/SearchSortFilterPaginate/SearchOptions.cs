namespace NHSUKSearchSortFilterPaginate.Models.SearchSortFilterPaginate
{
    using NHSUKSearchSortFilterPaginate.Helpers;
    using FuzzySharp.SimilarityRatio.Scorer;

    public class SearchOptions
    {
        public SearchOptions(
            string? searchString,
            int searchMatchCutoff = GenericSearchHelper.MatchCutoffScore,
            bool useTokeniseScore = false
        )
        {
            SearchString = searchString;
            SearchMatchCutoff = searchMatchCutoff;
            UseTokeniseScorer = useTokeniseScore;
        }

        public string? SearchString { get; set; }

        public int SearchMatchCutoff { get; set; }

        public bool UseTokeniseScorer { get; set; }

        public IRatioScorer? Scorer { get; set; }
    }
}
