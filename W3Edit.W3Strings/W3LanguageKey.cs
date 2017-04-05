using System;
using System.Collections.Generic;
using LanguageKey = System.UInt32;
using LanguageMagic = System.UInt32;
using LanguageNeutralID = System.UInt32;
using LanguageSpecificID = System.UInt32;

namespace W3Edit.W3Strings
{
    public class W3Language
    {
        public readonly LanguageKey Key;  // The unique identifier of the language as found in .w3speech files.
        public readonly LanguageMagic Magic;  // A value used to convert language specific and neutral IDs to one another.
        public readonly string Handle;  // An abbreviation for the language, such as "pl", "en", "de" and many more. 

        public static readonly IEnumerable<W3Language> languages = new List<W3Language>
        {
            new W3Language(0x00000000, 0x00000000, "__"),
            new W3Language(0x83496237, 0x73946816, "pl"),
            new W3Language(0x43975139, 0x79321793, "en"),
            new W3Language(0x75886138, 0x42791159, "de"),
            new W3Language(0x45931894, 0x12375973, "it"),
            new W3Language(0x23863176, 0x75921975, "fr"),
            new W3Language(0x24987354, 0x21793217, "cz"),
            new W3Language(0x18796651, 0x42387566, "es"),
            new W3Language(0x18632176, 0x16875467, "zh"),
            new W3Language(0x63481486, 0x42386347, "ru"),
            new W3Language(0x42378932, 0x67823218, "hu"),
            new W3Language(0x54834893, 0x59825646, "jp")
        }.AsReadOnly();

        public W3Language(LanguageKey key, LanguageMagic magic, string handle)
        {
            Key = key;
            Magic = magic;
            Handle = handle;
        }

        public static LanguageNeutralID languageNeutralID(LanguageSpecificID specificID, W3Language language)
        {
            return specificID ^ language.Magic;
        }

        public static LanguageSpecificID languageSpecificID(LanguageNeutralID specificID, W3Language language)
        {
            return specificID ^ language.Magic;
        }
    }
}