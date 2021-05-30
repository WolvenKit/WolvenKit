using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.CR2W.Helpers
{
    public static class Cr2wHelper
    {
        public static void WriteVariable(BinaryWriter file, IEditableVariable ivar)
        {
            if (ivar is CVariable cvar)
            {
                file.Write(cvar.GetnameId());
                file.Write(cvar.GettypeId());

                var pos = file.BaseStream.Position;
                file.Write((uint)0); // size placeholder


                cvar.Write(file);
                var endpos = file.BaseStream.Position;

                file.Seek((int)pos, SeekOrigin.Begin);
                var actualsize = (uint)(endpos - pos);
                file.Write(actualsize); // Write size
                file.Seek((int)endpos, SeekOrigin.Begin);
            }
            else
                throw new SerializationException();
        }

        public static int GetLastChildrenIndexRecursive(ICR2WExport chunk) =>
            !chunk.VirtualChildrenChunks.Any()
                ? chunk.ChunkIndex
                : GetLastChildrenIndexRecursive(chunk.VirtualChildrenChunks
                    .FirstOrDefault(_ => _.ChunkIndex == chunk.VirtualChildrenChunks.Max(p => p.ChunkIndex)));
    }
}
