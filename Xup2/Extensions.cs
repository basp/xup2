namespace Xup2
{
    using System.Text.RegularExpressions;

    public static class Extensions
    {
        public static string CollapseWhitespace(this string s) => 
            Regex.Replace(s, @"\s+", " ");
            
        public static string HumanizeDescription(this string s) => 
            s.Replace('_', ' ').CollapseWhitespace().Trim();
    }
}