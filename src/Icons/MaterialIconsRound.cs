namespace MauiIcons.Icons
{
    using System.Collections.Generic;

    public static class MaterialIconsRound
    {
        public const string FontAlias = "MaterialIconsRound";

        public static readonly IReadOnlyDictionary<string, string> Glyphs = new Dictionary<string, string>
        {
            // Common Material Icons Round glyphs
            // These are example mappings - actual Unicode values would come from the font file
            { "Home", "\ue88a" },
            { "Search", "\ue8b6" },
            { "Settings", "\ue8b8" },
            { "Person", "\ue7fd" },
            { "Favorite", "\ue87d" },
            { "Add", "\ue145" },
            { "Remove", "\ue15b" },
            { "Close", "\ue5cd" },
            { "Menu", "\ue5d2" },
            { "ArrowBack", "\ue5c4" },
            { "ArrowForward", "\ue5c8" },
            { "Check", "\ue5ca" },
            { "Delete", "\ue872" },
            { "Edit", "\ue3c9" },
            { "Refresh", "\ue5d5" },
            { "Share", "\ue80d" },
            { "Star", "\ue838" },
            { "Info", "\ue88e" },
            { "Warning", "\ue002" },
            { "Error", "\ue000" },
        };

        /// <summary>
        /// Gets the glyph (Unicode character) for a given icon name.
        /// </summary>
        /// <param name="iconName">The name of the icon</param>
        /// <returns>The Unicode character for the icon, or null if not found</returns>
        public static string GetGlyph(string iconName)
        {
            return Glyphs.TryGetValue(iconName, out var glyph) ? glyph : null;
        }
    }
}
