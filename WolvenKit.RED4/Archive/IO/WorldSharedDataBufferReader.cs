using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public partial class WorldSharedDataBufferReader : Red4Reader, IBufferReader
{
    public WorldSharedDataBufferReader(MemoryStream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.RootChunk is worldStreamingSector sec)
        {
            foreach (var handle in sec.Nodes)
            {
                ArgumentNullException.ThrowIfNull(handle);

                var value = handle.GetValue();
                if (value is worldInstancedMeshNode node1
                    && node1.WorldTransformsBuffer.SharedDataBuffer.GetValue() is worldSharedDataBuffer sdb1
                    && ReferenceEquals(sdb1.Buffer.Buffer, buffer))
                {
                    return ReadWorldTransformsBuffer(buffer);
                }   
                else if (value is worldInstancedDestructibleMeshNode node2
                         && node2.CookedInstanceTransforms.SharedDataBuffer.GetValue() is worldSharedDataBuffer sdb2
                         && ReferenceEquals(sdb2.Buffer.Buffer, buffer))
                {
                    return ReadCookedInstanceTransformsBuffer(buffer);
                }
            }
        }

        return EFileReadErrorCodes.UnsupportedVersion;
    }
}