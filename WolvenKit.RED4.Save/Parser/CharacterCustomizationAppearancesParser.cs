using WolvenKit.RED4.Types;
using WolvenKit.Core.Extensions;
using System.Diagnostics;
using WolvenKit.RED4.Save.IO;

namespace WolvenKit.RED4.Save
{
    public class CharacterCustomizationAppearances : INodeData
    {
        private bool _dataExists;
        private uint _unknown1;
        private byte[] _unknownFirstBytes;
        private Section _firstSection;
        private Section _secondSection;
        private Section _thirdSection;
        private List<StringTriple> _stringTriples;
        private List<string> _strings;
        public class StringTriple
        {
            private string _firstString;
            private string _secondString;
            private string _thirdString;

            public string FirstString
            {
                get => _firstString;
                set
                {
                    _firstString = value;
                }
            }

            public string SecondString
            {
                get => _secondString;
                set
                {
                    _secondString = value;
                }
            }

            public string ThirdString
            {
                get => _thirdString;
                set
                {
                    _thirdString = value;
                }
            }

            public StringTriple()
            {
                _firstString = "";
                _secondString = "";
                _thirdString = "";
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString} / {ThirdString}";
            }
        }

        public class HashValueEntry
        {
            private CResourceReference<appearanceAppearanceResource> _hash;
            private string _firstString;
            private string _secondString;
            private byte[] _trailingBytes;

            public CResourceReference<appearanceAppearanceResource> Hash
            {
                get => _hash;
                set
                {
                    _hash = value;
                }
            }

            public string FirstString
            {
                get => _firstString;
                set
                {
                    _firstString = value;
                }
            }

            public string SecondString
            {
                get => _secondString;
                set
                {
                    _secondString = value;
                }
            }

            public byte[] TrailingBytes
            {
                get => _trailingBytes;
                set
                {
                    _trailingBytes = value;
                }
            }

            public HashValueEntry()
            {
                _firstString = "";
                _secondString = "";
                _trailingBytes = new byte[8];
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }
        public class ValueEntry
        {
            private string _firstString;
            private string _secondString;
            private byte[] _trailingBytes;

            public string FirstString
            {
                get => _firstString;
                set
                {
                    _firstString = value;
                }
            }

            public string SecondString
            {
                get => _secondString;
                set
                {
                    _secondString = value;
                }
            }

            public byte[] TrailingBytes
            {
                get => _trailingBytes;
                set
                {
                    _trailingBytes = value;
                }
            }

            public ValueEntry()
            {
                _firstString = "";
                _secondString = "";
                _trailingBytes = new byte[8];
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }

        public class AppearanceSection
        {
            private string _sectionName;
            private List<HashValueEntry> _mainList;
            private List<ValueEntry> _additionalList;

            public string SectionName
            {
                get => _sectionName;
                set
                {
                    _sectionName = value;
                }
            }

            public List<HashValueEntry> MainList => _mainList;

            public List<ValueEntry> AdditionalList => _additionalList;

            public AppearanceSection()
            {
                _sectionName = "";
                _mainList = new List<HashValueEntry>();
                _additionalList = new List<ValueEntry>();
            }

            public override string ToString()
            {
                return $"{SectionName} ({MainList.Count} / {AdditionalList.Count})";
            }
        }

        public class Section
        {
            private List<AppearanceSection> _appearanceSections;

            public List<AppearanceSection> AppearanceSections => _appearanceSections;

            public Section()
            {
                _appearanceSections = new List<AppearanceSection>();
            }

            public override string ToString()
            {
                return $"{AppearanceSections.Count} inner sections";
            }
        }

        public bool DataExists
        {
            get => _dataExists;
            set
            {
                _dataExists = value;
            }
        }

        public uint Unknown1
        {
            get => _unknown1;
            set
            {
                _unknown1 = value;
            }
        }

        public byte[] UnknownFirstBytes
        {
            get => _unknownFirstBytes;
            set
            {
                _unknownFirstBytes = value;
            }
        }

        public Section FirstSection => _firstSection;

        public Section SecondSection => _secondSection;

        public Section ThirdSection => _thirdSection;

        public List<StringTriple> StringTriples => _stringTriples;

        public List<string> Strings => _strings;

        public CharacterCustomizationAppearances()
        {
            _firstSection = new Section();
            _secondSection = new Section();
            _thirdSection = new Section();
            _stringTriples = new List<StringTriple>();
            _strings = new List<string>();
        }

    }


    public class CharacterCustomizationAppearancesParser : INodeParser
    {
        public static string NodeName => Constants.NodeNames.CHARACTER_CUSTOMIZATION_APPEARANCES_NODE;

        public void Read(BinaryReader reader, NodeEntry node)
        {
            var data = new CharacterCustomizationAppearances();
            data.DataExists = reader.ReadBoolean();
            data.Unknown1 = reader.ReadUInt32();

            if (!data.DataExists)
            {
                node.Value = data;
                return;
            }

            data.UnknownFirstBytes = reader.ReadBytes(6);

            ReadSection(reader, data.FirstSection, ExpectedFirstSectionNames);
            ReadSection(reader, data.SecondSection, ExpectedSecondSectionNames);
            ReadSection(reader, data.ThirdSection, ExpectedThirdSectionNames);

            var count = reader.ReadUInt32();
            for (var i = 0; i < count; ++i)
            {
                data.StringTriples.Add(ReadStringTriple(reader));
            }

            // Only when SaveVersion > 171
            var scount = reader.ReadVLQInt32();
            for (var i = 0; i < scount; ++i)
            {
                data.Strings.Add(reader.ReadLengthPrefixedString());
            }

            node.Value = data;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (CharacterCustomizationAppearances)node.Value;

            writer.Write(data.DataExists);
            writer.Write(data.Unknown1);
            if (data.DataExists)
            {
                writer.Write(data.UnknownFirstBytes);

                WriteSection(writer, data.FirstSection);
                WriteSection(writer, data.SecondSection);
                WriteSection(writer, data.ThirdSection);

                writer.Write(data.StringTriples.Count);
                foreach (var st in data.StringTriples)
                {
                    WriteStringTriple(writer, st);
                }

                // Only when SaveVersion > 171
                writer.WriteVLQInt32(data.Strings.Count);
                foreach (var s in data.Strings)
                {
                    writer.WriteLengthPrefixedString(s);
                }
            }
        }

        private void WriteSection(BinaryWriter writer, CharacterCustomizationAppearances.Section section)
        {
            writer.Write(section.AppearanceSections.Count);
            foreach (var appearanceSection in section.AppearanceSections)
            {
                WriteAppearanceSection(writer, appearanceSection);
            }
        }

        private void WriteAppearanceSection(BinaryWriter writer, CharacterCustomizationAppearances.AppearanceSection appearanceSection)
        {
            writer.WriteLengthPrefixedString(appearanceSection.SectionName);

            writer.Write(appearanceSection.MainList.Count);
            foreach (var entry in appearanceSection.MainList)
            {
                writer.Write((ulong)entry.Hash.DepotPath);
                writer.WriteLengthPrefixedString(entry.FirstString);
                writer.WriteLengthPrefixedString(entry.SecondString);
                writer.Write(entry.TrailingBytes);
            }

            writer.Write(appearanceSection.AdditionalList.Count);
            foreach (var entry in appearanceSection.AdditionalList)
            {
                writer.WriteLengthPrefixedString(entry.FirstString);
                writer.WriteLengthPrefixedString(entry.SecondString);
                writer.Write(entry.TrailingBytes);
            }
        }

        private void WriteStringTriple(BinaryWriter writer, CharacterCustomizationAppearances.StringTriple st)
        {
            writer.WriteLengthPrefixedString(st.FirstString);
            writer.WriteLengthPrefixedString(st.SecondString);
            writer.WriteLengthPrefixedString(st.ThirdString);
        }

        private static List<string> ExpectedFirstSectionNames = new List<string>
        {
            Constants.Parsing.TPP_SECTION_NAME,
            Constants.Parsing.FPP_SECTION_NAME,
            Constants.Parsing.HAIRS_SECTION_NAME,
            Constants.Parsing.CHARACTER_CUSTOMIZATION_SECTION_NAME,
            Constants.Parsing.TPP_PROXY_SECTION_NAME,
            Constants.Parsing.FPP_PROXY_SECTION_NAME,
            Constants.Parsing.FPP_HAIRS_SECTION_NAME,
            Constants.Parsing.TPP_PHOTOMODE_SECTION_NAME
        };

        private static List<string> ExpectedSecondSectionNames = new List<string>
        {
            Constants.Parsing.HOLSTERED_DEFAULT_SECTION_NAME,
            Constants.Parsing.HOLSTERED_STRONG_SECTION_NAME,
            Constants.Parsing.HOLSTERED_NANOWIRE_SECTION_NAME,
            Constants.Parsing.HOLSTERED_LAUNCHER_SECTION_NAME,
            Constants.Parsing.HOLSTERED_MANTIS_SECTION_NAME,
            Constants.Parsing.HOLSTERED_DEFAULT_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_DEFAULT_FPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_STRONG_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_STRONG_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_STRONG_SECTION_NAME,
            Constants.Parsing.HOLSTERED_NANOWIRE_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_NANOWIRE_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_NANOWIRE_SECTION_NAME,
            Constants.Parsing.CHARACTER_CUSTOMIZATION_SECTION_NAME, // Yes, in both sections
            Constants.Parsing.PERSONAL_LINK_SIMPLE_SECTION_NAME,
            Constants.Parsing.PERSONAL_LINK_ADVANCED_SECTION_NAME,
            Constants.Parsing.HOLSTERED_LAUNCHER_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_LAUNCHER_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_LAUNCHER_SECTION_NAME,
            Constants.Parsing.HOLSTERED_MANTIS_TPP_SECTION_NAME,
            Constants.Parsing.HOLSTERED_MANTIS_FPP_SECTION_NAME,
            Constants.Parsing.UNHOLSTERED_MANTIS_SECTION_NAME,
        };

        private static List<string> ExpectedThirdSectionNames = new List<string>
        {
            Constants.Parsing.FPP_BODY_SECTION_NAME,
            Constants.Parsing.TPP_BODY_SECTION_NAME,
            Constants.Parsing.CHARACTER_CREATION_SECTION_NAME,
            Constants.Parsing.GENITALS_SECTION_NAME,
            Constants.Parsing.BREAST_SECTION_NAME,
            Constants.Parsing.LIFTED_FEET_SECTION_NAME,
            Constants.Parsing.FLAT_FEET_SECTION_NAME
        };

        private void ReadSection(BinaryReader reader, CharacterCustomizationAppearances.Section section, List<string> expectedSectionNames)
        {
            var count = reader.ReadUInt32();

            for (uint i = 0; i < count; ++i)
            {
                section.AppearanceSections.Add(ReadAppearanceSection(reader, expectedSectionNames));
            }
        }

        private CharacterCustomizationAppearances.AppearanceSection ReadAppearanceSection(BinaryReader reader, List<string> expectedNames)
        {
            var sectionName = reader.ReadLengthPrefixedString();
            Debug.Assert(expectedNames.Contains(sectionName));

            var appearanceSection = new CharacterCustomizationAppearances.AppearanceSection { SectionName = sectionName };


            int count = reader.ReadInt32();
            if (count > 0)
            {
                ReadHashValueSection(reader, appearanceSection.MainList, count);
            }

            count = reader.ReadInt32();
            if (count > 0)
            {
                ReadValueSection(reader, appearanceSection.AdditionalList, count);
            }

            return appearanceSection;
        }

        private void ReadHashValueSection(BinaryReader reader, List<CharacterCustomizationAppearances.HashValueEntry> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var entry = new CharacterCustomizationAppearances.HashValueEntry();
                // CSE is doing a version check here on ArchiveVersion < 195
                // Unt64 only read if ArchiveVersion >= 195, otherwise: https://github.com/PixelRick/CyberpunkSaveEditor/blob/7c47c6c7ce099c714e2ba43515380f99a2422c20/Source/cserialization/cnodes/CCharacterCustomization.hpp#L74
                entry.Hash = new CResourceReference<appearanceAppearanceResource> { DepotPath = reader.ReadUInt64() };
                entry.FirstString = reader.ReadLengthPrefixedString();
                entry.SecondString = reader.ReadLengthPrefixedString();
                entry.TrailingBytes = reader.ReadBytes(8);
                collection.Add(entry);
            }
        }

        private void ReadValueSection(BinaryReader reader, List<CharacterCustomizationAppearances.ValueEntry> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var entry = new CharacterCustomizationAppearances.ValueEntry();
                entry.FirstString = reader.ReadLengthPrefixedString();
                entry.SecondString = reader.ReadLengthPrefixedString();
                entry.TrailingBytes = reader.ReadBytes(8);
                collection.Add(entry);
            }
        }

        private CharacterCustomizationAppearances.StringTriple ReadStringTriple(BinaryReader reader)
        {
            var result = new CharacterCustomizationAppearances.StringTriple();
            result.FirstString = reader.ReadLengthPrefixedString();
            result.SecondString = reader.ReadLengthPrefixedString();
            result.ThirdString = reader.ReadLengthPrefixedString();
            return result;
        }
    }

}
