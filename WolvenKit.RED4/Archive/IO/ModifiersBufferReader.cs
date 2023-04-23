using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Save;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO;

public class ModifiersBufferReader : Red4Reader, IBufferReader
{
    public ModifiersBufferReader(Stream input) : base(input)
    {
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var data = new ModifiersBuffer();

        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            var clsName = _reader.ReadLengthPrefixedString();

            var statType = SaveHashHelper.GetStatType(_reader.ReadUInt64());
            var modifierType = (Enums.gameStatModifierType)_reader.ReadUInt32();

            if (clsName == "gameConstantStatModifier")
            {
                data.Entries.Add(new gameConstantStatModifierData_Deprecated
                {
                    StatType = statType,
                    ModifierType = modifierType,
                    Value = ReadCFloat()
                });
            }
            else if (clsName == "gameCombinedStatModifier")
            {
                data.Entries.Add(new gameCombinedStatModifierData_Deprecated
                {
                    StatType = statType,
                    ModifierType = modifierType,
                    RefStatType = SaveHashHelper.GetStatType(_reader.ReadUInt64()),
                    Operation = (Enums.gameCombinedStatOperation)_reader.ReadUInt32(),
                    RefObject = (Enums.gameStatObjectsRelation)_reader.ReadUInt32(),
                    Value = ReadCFloat()
                });
            }
            else if (clsName == "gameCurveStatModifier")
            {
                data.Entries.Add(new gameCurveStatModifierData_Deprecated
                {
                    StatType = statType,
                    ModifierType = modifierType,
                    CurveName = _reader.ReadLengthPrefixedString(),
                    ColumnName = _reader.ReadLengthPrefixedString(),
                    CurveStat = SaveHashHelper.GetStatType(_reader.ReadUInt64()),
                });

                var unk = _reader.ReadUInt32();
                if (unk != 0)
                {
                    throw new TodoException("gameCurveStatModifier");
                }
            }
            else
            {
                throw new NotImplementedException(clsName);
            }
        }

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;

        // Maybe change it someday...
        /*var entries = new List<gamedataStatModifier_Record>();

        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            var clsName = _reader.ReadLengthPrefixedString();

            var statType = (TweakDBID)$"BaseStats.{SaveHashHelper.GetStatType(_reader.ReadUInt64())}";
            var modifierType = (CName)((Enums.gameStatModifierType)_reader.ReadUInt32()).ToString();

            if (clsName == "gameConstantStatModifier")
            {
                entries.Add(new gamedataConstantStatModifier_Record
                {
                    StatType = statType,
                    ModifierType = modifierType,
                    Value = ReadCFloat()
                });
            }
            else if (clsName == "gameCombinedStatModifier")
            {
                entries.Add(new gamedataCombinedStatModifier_Record
                {
                    StatType = statType,
                    ModifierType = modifierType,
                    RefStat = (TweakDBID)$"BaseStats.{SaveHashHelper.GetStatType(_reader.ReadUInt64())}",
                    OpSymbol = (CName)((Enums.gameCombinedStatOperation)_reader.ReadUInt32()).ToString(),
                    RefObject = (CName)((Enums.gameStatObjectsRelation)_reader.ReadUInt32()).ToString(),
                    Value = ReadCFloat()
                });
            }
            else if (clsName == "gameCurveStatModifier")
            {
                entries.Add(new gamedataCurveStatModifier_Record
                {
                    StatType = statType,
                    ModifierType = modifierType,
                    Id = ReadCString(),
                    Column = ReadCString(),
                    RefStat = (TweakDBID)$"BaseStats.{SaveHashHelper.GetStatType(_reader.ReadUInt64())}",
                });

                var unk = _reader.ReadUInt32();
                if (unk != 0)
                {
                    throw new TodoException("gameCurveStatModifier");
                }
            }
            else
            {
                throw new NotImplementedException(clsName);
            }
        }

        return EFileReadErrorCodes.NoError;*/
    }
}