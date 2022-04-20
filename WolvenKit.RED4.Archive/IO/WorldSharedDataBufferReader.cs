using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class WorldSharedDataBufferReader : Red4Reader, IBufferReader
    {
        public WorldSharedDataBufferReader(MemoryStream ms) : base(ms)
        {

        }

        public EFileReadErrorCodes ReadBuffer(RedBuffer buffer, Type fileRootType)
        {
            if (buffer.RootChunk is worldStreamingSector sec)
            {
                foreach (var handle in sec.Nodes)
                {
                    var value = handle.GetValue();
                    if (value is worldInstancedMeshNode node1
                        && node1.WorldTransformsBuffer.SharedDataBuffer.GetValue() is worldSharedDataBuffer sdb1
                        && ReferenceEquals(sdb1.Buffer.Buffer, buffer))
                    {
                        return ReadWorldTransformsBuffer(buffer, fileRootType);
                    }   
                    else if (value is worldInstancedDestructibleMeshNode node2
                        && node2.CookedInstanceTransforms.SharedDataBuffer.GetValue() is worldSharedDataBuffer sdb2
                        && ReferenceEquals(sdb2.Buffer.Buffer, buffer))
                    {
                        return ReadCookedInstanceTransformsBuffer(buffer, fileRootType);
                    }
                }
            }

            return EFileReadErrorCodes.UnsupportedVersion;
        }
    }
}
