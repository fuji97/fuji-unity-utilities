namespace FujiUnityUtilities.Extensions {
    public static class StringExtensions {
        public static string ReplaceNewline(this string text) {
            return text
                .Replace("\\n", "\n")
                .Replace("\\t", "\t");
        }
    }
}