using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;
using WolvenKit.Common.Model;
using System.Linq;

namespace WolvenKit.CR2W.Types
{
    public partial class CBitmapTexture : ITexture, IByteSource
    {




        public CBitmapTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {



        }

        public byte[] GetBytes()
        {
            var isUncooked = this.REDFlags == 0;
            byte[] bytesource;
            

            return null;
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }
    }
}
