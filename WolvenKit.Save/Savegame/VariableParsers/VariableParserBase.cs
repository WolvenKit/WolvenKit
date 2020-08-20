using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using W3SavegameEditor.Core.Exceptions;
using W3SavegameEditor.Core.Savegame.Values;
using W3SavegameEditor.Core.Savegame.Values.Engine;
using W3SavegameEditor.Core.Savegame.Variables;

namespace W3SavegameEditor.Core.Savegame.VariableParsers
{
    public abstract class VariableParserBase
    {
        public string[] Names { get; set; }

        public abstract string MagicNumber { get; }

        public abstract Type SupportedType { get; }

        public abstract Variable Parse(BinaryReader reader, ref int size);

        public abstract void Verify(BinaryReader reader, ref int size);
    }

    public abstract class VariableParserBase<T> : VariableParserBase where T : Variable
    {
        public override Type SupportedType
        {
            get { return typeof(T); }
        }

        [DebuggerHidden]
        public override Variable Parse(BinaryReader reader, ref int size)
        {
            return ParseImpl(reader, ref size);
        }

        public abstract T ParseImpl(BinaryReader reader, ref int size);

        public override void Verify(BinaryReader reader, ref int size)
        {
            var bytesToRead = MagicNumber.Length;
            var readMagicNumber = reader.ReadString(bytesToRead);
            if (readMagicNumber != MagicNumber)
            {
                throw new ParseVariableException(
                    string.Format(
                    "Expeced {0} but read {1} at {2}",
                    MagicNumber,
                    readMagicNumber,
                    reader.BaseStream.Position - bytesToRead));
            }

            size -= bytesToRead;
        }

        protected VariableValue ReadValue(BinaryReader reader, string type, ref int size)
        {
            switch (type)
            {
                case "String":
                    {
                        // TODO: Implement correct variable-length decoding
                        var headerByte = reader.ReadByte();
                        size -= sizeof(byte);

                        bool encodedStringLength = (headerByte & 128) > 0;
                        if (encodedStringLength)
                        {
                            // HACK: Sometimes a single byte has to be skipped
                            if (reader.PeekByte() == 0x01)
                            {
                                reader.ReadByte();
                                size -= sizeof(byte);
                            }

                            byte stringLength = (byte)(headerByte & 127);
                            string value = reader.ReadString(stringLength);
                            size -= stringLength;
                            return VariableValue<string>.Create(value);
                        }
                        else
                        {
                            // TODO: Analyze how this can be read.
                            byte[] unknown = reader.ReadBytes(size);
                            size = 0;

                            return VariableValue<string>.Create("Unknown (" + Encoding.ASCII.GetString(unknown) + ")");
                        }
                    }
                case "StringAnsi":
                    {
                        var length = reader.ReadByte();
                        byte[] data = reader.ReadBytes(length);
                        size -= sizeof(byte) + length;
                        string value = Encoding.ASCII.GetString(data).TrimEnd(char.MinValue);
                        return VariableValue<string>.Create(value);
                    }
                case "CName":
                    {
                        short cnameIndex = reader.ReadInt16();
                        size -= sizeof(short);
                        string value;
                        if (cnameIndex == 0 || cnameIndex > Names.Length)
                        {
                            value = "Unknown";
                        }
                        else
                        {
                            value = Names[cnameIndex - 1];
                        }

                        return VariableValue<string>.Create(value);
                    }
                case "CGUID":
                    {
                        var guidData = reader.ReadBytes(16);
                        size -= 16;
                        var value = new Guid(guidData);
                        return VariableValue<Guid>.Create(value);
                    }
                case "Bool":
                    {
                        bool value = reader.ReadBoolean();
                        size -= sizeof(bool);

                        return VariableValue<bool>.Create(value);
                    }
                case "Uint8":
                    {
                        byte value = reader.ReadByte();
                        size -= sizeof(byte);
                        return VariableValue<byte>.Create(value);
                    }
                case "Uint16":
                    {
                        ushort value = reader.ReadUInt16();
                        size -= sizeof(ushort);
                        return VariableValue<ushort>.Create(value);
                    }
                case "Uint32":
                    {
                        uint value = reader.ReadUInt32();
                        size -= sizeof(uint);
                        return VariableValue<uint>.Create(value);
                    }
                case "Uint64":
                    {
                        ulong value = reader.ReadUInt64();
                        size -= sizeof(ulong);
                        return VariableValue<ulong>.Create(value);
                    }
                case "Int8":
                    {
                        sbyte value = reader.ReadSByte();
                        size -= sizeof(sbyte);
                        return VariableValue<sbyte>.Create(value);
                    }
                case "Int16":
                    {
                        short value = reader.ReadInt16();
                        size -= sizeof(short);
                        return VariableValue<short>.Create(value);
                    }
                case "Int32":
                    {
                        int value = reader.ReadInt32();
                        size -= sizeof(int);
                        return VariableValue<int>.Create(value);
                    }
                case "Int64":
                    {
                        long value = reader.ReadInt64();
                        size -= sizeof(long);
                        return VariableValue<long>.Create(value);
                    }
                case "Double":
                    {
                        double value = reader.ReadDouble();
                        size -= sizeof(double);
                        return VariableValue<double>.Create(value);
                    }
                case "Float":
                    {
                        float value = reader.ReadSingle();
                        size -= sizeof(float);
                        return VariableValue<float>.Create(value);
                    }
                case "Vector":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown = reader.ReadBytes(35);
                        size -= 35;
                        return VariableValue<byte[]>.Create(unknown);
                    }
                case "Vector2":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown = reader.ReadBytes(19);
                        size -= 19;
                        return VariableValue<byte[]>.Create(unknown);
                    }
                case "EulerAngles":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown1 = reader.ReadBytes(3);
                        double unknown2 = reader.ReadDouble();
                        double unknown3 = reader.ReadDouble();
                        double unknown4 = reader.ReadDouble();
                        size -= 3 + 3 * sizeof(double);

                        var value = new EulerAngles
                        {
                            Unknown1 = unknown1,
                            Pitch = unknown2,
                            Yaw = unknown3,
                            Roll = unknown4,
                        };
                        return VariableValue<EulerAngles>.Create(value);
                    }
                case "EngineTime":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown = reader.ReadBytes(3);
                        size -= 3;
                        return VariableValue<byte[]>.Create(unknown);
                    }
                case "GameTime":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown = reader.ReadBytes(11);
                        size -= 11;
                        return VariableValue<byte[]>.Create(unknown);
                    }
                case "EntityHandle":
                    {
                        // TODO: Analyze how this can be read.
                        byte unknown1 = reader.ReadByte();
                        size -= sizeof(byte);
                        byte unknown2 = 0x00;
                        byte[] unknown3 = null;
                        if (unknown1 > 0)
                        {
                            unknown2 = reader.ReadByte();
                            unknown3 = reader.ReadBytes(16);
                            size -= 17 * sizeof(byte);
                        }

                        var value = new EntityHandle
                        {
                            Unknown1 = unknown1,
                            Unknown2 = unknown2,
                            Unknown3 = unknown3,
                        };
                        return VariableValue<EntityHandle>.Create(value);
                    }
                case "IdTag":
                    {
                        // TODO: Analyze how this can be read.
                        byte unknown1 = reader.ReadByte();
                        int unknown2 = reader.ReadInt32();
                        int unknown3 = reader.ReadInt32();
                        int unknown4 = reader.ReadInt32();
                        int unknown5 = reader.ReadInt32();
                        size -= 17;

                        var value = new IdTag
                        {
                            Unknown1 = unknown1,
                            Unknown2 = unknown2,
                            Unknown3 = unknown3,
                            Unknown4 = unknown4,
                            Unknown5 = unknown5,
                        };
                        return VariableValue<IdTag>.Create(value);
                    }
                case "TagList":
                    {
                        byte tagListHeader = reader.ReadByte();
                        size -= sizeof(byte);
                        bool tagListFlag = (tagListHeader & 128) > 0;
                        byte tagListCount = (byte)(tagListHeader & 127);
                        short[] tagListEntries = new short[tagListCount];
                        for (int i = 0; i < tagListCount; i++)
                        {
                            tagListEntries[i] = reader.ReadInt16(); // NameIndex?
                        }
                        size -= tagListCount * sizeof(short);

                        var value = new TagList
                        {
                            Flag = tagListFlag,
                            Entities = tagListEntries
                        };
                        return VariableValue<TagList>.Create(value);
                    }
                case "eGwintFaction":
                case "EJournalStatus":
                case "EZoneName":
                case "EDifficultyMode":
                    {
                        byte unknown1 = reader.ReadByte();
                        byte unknown2 = reader.ReadByte(); // Index?
                        size -= 2 * sizeof(byte);

                        var value = new W3Enum
                        {
                            Unknown1 = unknown1,
                            Unknown2 = unknown2,
                        };
                        return VariableValue<W3Enum>.Create(value);
                    }
                case "W3EnvironmentManager":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown = reader.ReadBytes(19);
                        size -= 19;
                        return VariableValue<byte[]>.Create(unknown);
                    }
                case "SQuestThreadSuspensionData":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown = reader.ReadBytes(29);
                        size -= 29;
                        return VariableValue<byte[]>.Create(unknown);
                    }
                case "SActionPointId":
                    {
                        // TODO: Analyze how this can be read.
                        byte unknown1 = reader.ReadByte();
                        short unknown2 = reader.ReadInt16();
                        size -= 3;

                        byte[] unknown3 = new byte[0];
                        if (unknown2 > 0)
                        {
                            unknown3 = reader.ReadBytes(40);
                            size -= 40;
                        }

                        return VariableValue<byte[]>.Create(unknown3);
                    }
                case "EAIAttitude":
                case "CPlayerInput":
                case "EBehaviorGraph":
                case "ESignType":
                case "EVehicleSlot":
                case "SBuffImmunity":
                case "SGameplayFact":
                case "SGlossaryImageOverride":
                case "SRadialSlotDef":
                case "SItemUniqueId":
                case "SRewardMultiplier":
                case "W3AbilityManager":
                case "W3EffectManager":
                case "W3LevelManager":
                case "W3Reputation":
                case "W3TutorialManagerUIHandler":
                case "WeaponHolster":
                    {
                        // TODO: Analyze how this can be read.
                        byte[] unknown = reader.ReadBytes(size);
                        size = 0;
                        return VariableValue<byte[]>.Create(unknown);
                    }
                case "CEntityTemplate":
                    {
                        // Might just be the same format as "String"
                        byte headerByte = reader.ReadByte();
                        size -= sizeof(byte);

                        bool encodedStringLength = (headerByte & 128) > 0;
                        if (encodedStringLength)
                        {
                            // HACK: Sometimes a single byte has to be skipped
                            if (reader.PeekByte() == 0x01)
                            {
                                reader.ReadByte();
                                size -= sizeof(byte);
                            }

                            byte stringLength = (byte)(headerByte & 127);
                            string value = reader.ReadString(stringLength);
                            size -= stringLength;
                            return VariableValue<string>.Create(value);
                        }
                        else
                        {
                            // TODO: Analyze how this can be read.
                            byte[] unknown = reader.ReadBytes(size);
                            size = 0;
                            return VariableValue<byte[]>.Create(unknown);
                        }
                    }
                default:
                    {
                        if (type.StartsWith("array:2,0,"))
                        {
                            var arrayElementType = type.Substring("array:2,0,".Length);
                            var arrayElementClrType = GetClrType(arrayElementType);
                            int arrayLength = reader.ReadInt32();
                            size -= sizeof(int);

                            var arrayValue = VariableArrayValue.Create(arrayElementClrType, arrayLength);
                            for (int i = 0; i < arrayLength; i++)
                            {
                                arrayValue[i] = ReadValue(reader, arrayElementType, ref size).Object;
                            }

                            return arrayValue;
                        }
                        else if (type.StartsWith("handle:"))
                        {
                            var handleType = type.Substring("handle:".Length);
                            var value = ReadValue(reader, handleType, ref size);
                            return VariableHandleValue<object>.Create(value);
                        }
                        else if (type.StartsWith("soft:"))
                        {
                            var handleType = type.Substring("soft:".Length);
                            var value = ReadValue(reader, handleType, ref size);
                            return VariableSoftValue<object>.Create(value);
                        }
                        else
                        {
                            Debug.WriteLine("Unknown type '{0}' bytes left to read {1}", type, size);
                            byte[] unknown = reader.ReadBytes(size);
                            size = 0;
                            return VariableValue<byte[]>.Create(unknown);
                        }
                    }
            }
        }

        private Type GetClrType(string type)
        {
            switch (type)
            {
                case "Uint8":
                    return typeof (byte);
            }
            return typeof (object);
        }
    }
}
