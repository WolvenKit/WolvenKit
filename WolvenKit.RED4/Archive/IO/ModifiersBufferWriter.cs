using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Save;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class ModifiersBufferWriter : IDisposable
{
    public ILoggerService LoggerService { get; set; }

    private Stream _ms;
    private bool _disposed;

    public ModifiersBufferWriter(Stream ms)
    {
        _ms = ms;
    }

    public void WriteBuffer(ModifiersBuffer buffer)
    {
        using var bw = new BinaryWriter(_ms, Encoding.UTF8, true);

        foreach (var entry in buffer.Entries)
        {
            if (entry is gameConstantStatModifierData_Deprecated constantStat)
            {
                bw.WriteLengthPrefixedString("gameConstantStatModifier");
                bw.Write(SaveHashHelper.GetStatHash(constantStat.StatType));
                bw.Write((int)(Enums.gameStatModifierType)constantStat.ModifierType);

                bw.Write(constantStat.Value);
            }

            if (entry is gameCombinedStatModifierData_Deprecated combinedStat)
            {
                bw.WriteLengthPrefixedString("gameCombinedStatModifier");
                bw.Write(SaveHashHelper.GetStatHash(combinedStat.StatType));
                bw.Write((int)(Enums.gameStatModifierType)combinedStat.ModifierType);

                bw.Write(SaveHashHelper.GetStatHash(combinedStat.RefStatType));
                bw.Write((int)(Enums.gameCombinedStatOperation)combinedStat.Operation);
                bw.Write((int)(Enums.gameStatObjectsRelation)combinedStat.RefObject);
                bw.Write(combinedStat.Value);
            }

            if (entry is gameCurveStatModifierData_Deprecated curveStat)
            {
                bw.WriteLengthPrefixedString("gameCurveStatModifier");
                bw.Write(SaveHashHelper.GetStatHash(curveStat.StatType));
                bw.Write((int)(Enums.gameStatModifierType)curveStat.ModifierType);

                bw.WriteLengthPrefixedString(curveStat.CurveName);
                bw.WriteLengthPrefixedString(curveStat.ColumnName);
                bw.Write(SaveHashHelper.GetStatHash(curveStat.CurveStat));

                // Not sure what this is yet...
                bw.Write(0);
            }
        }
    }

    #region IDisposable

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _ms.Close();
            }
            _disposed = true;
        }
    }

    public void Dispose() => Dispose(true);

    public virtual void Close() => Dispose(true);

    #endregion IDisposable
}