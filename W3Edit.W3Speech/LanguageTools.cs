using WolvenKit.W3Strings;

namespace WolvenKit.W3Speech
{
    public static class LanguageTools
    {
        /// <summary>
        /// Converts the language specific id as found in w3speech files to the language neutral id that is the same across all languages.
        /// </summary>
        /// <param name="specific_id">The language specific id as found in w3speech files.</param>
        /// <param name="language">The language information used to convert the id.</param>
        /// <returns>The language neutral id that is the same across all languages.</returns>
        public static LanguageNeutralID Convert(LanguageSpecificID specific_id, W3Language language)
        {
            return new LanguageNeutralID(specific_id.value ^ language.Magic.value);
        }

        /// <summary>
        /// Converts the language neutral id that is the same across all languages to the language specific id as found in w3speech files.
        /// </summary>
        /// <param name="neutral_id">The language neutral id that is the same across all languages.</param>
        /// <param name="language">The language information used to convert the id.</param>
        /// <returns>The language specific id as found in w3speech files.</returns>
        public static LanguageSpecificID Convert(LanguageNeutralID neutral_id, W3Language language)
        {
            return new LanguageSpecificID(neutral_id.value ^ language.Magic.value);
        }
    }
}
