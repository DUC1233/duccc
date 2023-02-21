namespace NW2.Utilities
{
    public class Functions
    {
        public static string TitileSlugGeneration(string title)
        {
            string sTitle = SlugGenerator.SlugGenerator.GenerateSlug(title) + ".html";
            return sTitle;
        }
    }
}
