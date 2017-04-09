using System;
using System.Collections.Generic;

namespace WolvenKit.W3Strings
{
    public class W3Language
    {
        /// <summary>
        /// The unique identifier of the language as found in w3speech files.
        /// </summary>
        public readonly W3LanguageKey Key;
        /// <summary>
        /// A value used to convert language specific and neutral IDs to one another.
        /// </summary>
        public readonly W3LanguageMagic Magic;
        /// <summary>
        /// An abbreviation for the language, such as "pl", "en", "de" and many more.
        /// </summary>
        public readonly string Handle;

        /// <summary>
        /// A list of information about the known languages.
        /// </summary>
        public static readonly IEnumerable<W3Language> languages = new List<W3Language>
        {
            new W3Language(new W3LanguageKey(0x00000000), new W3LanguageMagic(0x00000000), "__"),
            new W3Language(new W3LanguageKey(0x83496237), new W3LanguageMagic(0x73946816), "pl"),
            new W3Language(new W3LanguageKey(0x43975139), new W3LanguageMagic(0x79321793), "en"),
            new W3Language(new W3LanguageKey(0x75886138), new W3LanguageMagic(0x42791159), "de"),
            new W3Language(new W3LanguageKey(0x45931894), new W3LanguageMagic(0x12375973), "it"),
            new W3Language(new W3LanguageKey(0x23863176), new W3LanguageMagic(0x75921975), "fr"),
            new W3Language(new W3LanguageKey(0x24987354), new W3LanguageMagic(0x21793217), "cz"),
            new W3Language(new W3LanguageKey(0x18796651), new W3LanguageMagic(0x42387566), "es"),
            new W3Language(new W3LanguageKey(0x18632176), new W3LanguageMagic(0x16875467), "zh"),
            new W3Language(new W3LanguageKey(0x63481486), new W3LanguageMagic(0x42386347), "ru"),
            new W3Language(new W3LanguageKey(0x42378932), new W3LanguageMagic(0x67823218), "hu"),
            new W3Language(new W3LanguageKey(0x54834893), new W3LanguageMagic(0x59825646), "jp")
        }.AsReadOnly();

        public W3Language(W3LanguageKey key, W3LanguageMagic magic, string handle)
        {
            Key = key;
            Magic = magic;
            Handle = handle;
        }

        public override string ToString()
        {
            return $"W3Language({Key},{Magic},{Handle})";
        }
    }

    /// <summary>
    /// The unique identifier of the language as found in .w3speech files.
    /// </summary>
    public class W3LanguageKey
    {
        public readonly UInt32 value;

        public W3LanguageKey(UInt32 value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"W3LanguageKey({value})";
        }
    }

    /// <summary>
    /// A value used to convert language specific and neutral IDs to one another.
    /// </summary>
    public class W3LanguageMagic
    {
        public readonly UInt32 value;

        public W3LanguageMagic(UInt32 value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"W3LanguageMagic({value})";
        }
    }
}