using System.Reflection.Metadata;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class worldNodeDataWriter : Red4Writer
{
    public worldNodeDataWriter(Stream ms) : base(ms)
    {

    }

    public void WriteBuffer(worldNodeDataBuffer ssb)
    {
        if (ssb.Count > 0 && ssb[0] is Types.Legacy.V2310.worldCompiledNodeInstanceSetupInfo)
        {
            foreach (var info in ssb)
            {
                WriteV62((Types.Legacy.V2310.worldCompiledNodeInstanceSetupInfo)info);
            }
        }
        else if (ssb.Count > 0 && ssb[0] is worldCompiledNodeInstanceSetupInfo)
        {
            foreach (var info in ssb)
            {
                WriteV68((worldCompiledNodeInstanceSetupInfo)info);
            }
        }
        else
        {
            throw new NotSupportedException();
        }
    }

    private void WriteV62(Types.Legacy.V2310.worldCompiledNodeInstanceSetupInfo info)
    {
        _writer.Write(info.Transform.Position.X);
        _writer.Write(info.Transform.Position.Y);
        _writer.Write(info.Transform.Position.Z);
        _writer.Write(info.Transform.Position.W);

        _writer.Write(info.Transform.Orientation.I);
        _writer.Write(info.Transform.Orientation.J);
        _writer.Write(info.Transform.Orientation.K);
        _writer.Write(info.Transform.Orientation.R);

        _writer.Write(info.Scale.X);
        _writer.Write(info.Scale.Y);
        _writer.Write(info.Scale.Z);

        _writer.Write(info.SecondaryRefPointPosition.X);
        _writer.Write(info.SecondaryRefPointPosition.Y);
        _writer.Write(info.SecondaryRefPointPosition.Z);

        _writer.Write(info.StreamingRefPoint.X);
        _writer.Write(info.StreamingRefPoint.Y);
        _writer.Write(info.StreamingRefPoint.Z);

        _writer.Write(info.PreboostStreamingRefPoint.X);
        _writer.Write(info.PreboostStreamingRefPoint.Y);
        _writer.Write(info.PreboostStreamingRefPoint.Z);

        _writer.Write((ulong)info.PatchedNode);
        _writer.Write(info.GlobalNodeId.Hash);
        _writer.Write(info.ProxyMeshId.Hash);
        _writer.Write((ulong)info.ExternalInplaceResourceHash.DepotPath);

        _writer.Write(info.SecondaryRefPointDistance);
        _writer.Write(info.StreamingDistance);

        var bitField = 0UL;
        bitField |= info.NodeIdx & 0xFFFFF;
        bitField |= ((ulong)(Enums.ENodeFlags)info.NodeFlags & 0x1FFFFF) << 20;
        bitField |= (info.StreamingPriority & 0xFF) << 41;
        _writer.Write(bitField);

        var bitField2 = 0UL;
        bitField2 |= info.TodvisMask & 0xFFFF;
        _writer.Write(bitField2);

        _writer.Write((byte)(Enums.worldStreamingDataGroup)info.DataGroup);

        _writer.Write(new byte[7]);
    }

    private void WriteV68(worldCompiledNodeInstanceSetupInfo info)
    {
        _writer.Write(info.Transform.Position.X);
        _writer.Write(info.Transform.Position.Y);
        _writer.Write(info.Transform.Position.Z);
        _writer.Write(info.Transform.Position.W);

        _writer.Write(info.Transform.Orientation.I);
        _writer.Write(info.Transform.Orientation.J);
        _writer.Write(info.Transform.Orientation.K);
        _writer.Write(info.Transform.Orientation.R);

        _writer.Write(info.Scale.X);
        _writer.Write(info.Scale.Y);
        _writer.Write(info.Scale.Z);

        _writer.Write(info.SecondaryRefPointPosition.X);
        _writer.Write(info.SecondaryRefPointPosition.Y);
        _writer.Write(info.SecondaryRefPointPosition.Z);

        _writer.Write(info.StreamingRefPoint.X);
        _writer.Write(info.StreamingRefPoint.Y);
        _writer.Write(info.StreamingRefPoint.Z);

        _writer.Write(info.PreboostStreamingRefPoint.X);
        _writer.Write(info.PreboostStreamingRefPoint.Y);
        _writer.Write(info.PreboostStreamingRefPoint.Z);

        _writer.Write((ulong)info.PatchedNode);
        _writer.Write(info.GlobalNodeId.Hash);
        _writer.Write(info.ProxyMeshId.Hash);
        _writer.Write((ulong)info.ExternalInplaceResourceHash.DepotPath);

        var bitField = 0UL;
        bitField |= info.NodeIdx & 0x7_FFFFUL;
        bitField |= ((ulong)(Enums.ENodeFlags)info.NodeFlags & 0x1F_FFFFUL) << 19;
        bitField |= (info.StreamingPriority & 0xFFUL) << 40;
        bitField |= (info.TodvisMask & 0xFFFFUL) << 48;
        _writer.Write(bitField);

        _writer.Write(info.SecondaryRefPointDistance);
        _writer.Write(info.StreamingDistance);
        _writer.Write(info.InstanceIndex);
        _writer.Write((byte)(Enums.worldStreamingDataGroup)info.DataGroup);
        _writer.Write(new byte[11]);
    }
}
