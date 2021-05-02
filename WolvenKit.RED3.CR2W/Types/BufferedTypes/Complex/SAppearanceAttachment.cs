using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.RED3.CR2W.Types;
using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;
using WolvenKit.Interfaces.Core;

namespace WolvenKit.RED3.CR2W.Types
{
    public partial class SAppearanceAttachment : CVariable
    {

        [Ordinal(1000)] [REDBuffer(true)] public CBufferVLQInt32<IReferencable> Data { get; set; }

        public SAppearanceAttachment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Data = new CBufferVLQInt32<IReferencable>(cr2w, this, nameof(Data)) { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var startpos = file.BaseStream.Position;

            var bytecount = file.ReadUInt32();

            // read classes
            var count = file.ReadBit6();
            for (int i = 0; i < count; i++)
            {
                var ClassName = new CName(cr2w, null, "");
                ClassName.Read(file, 2);

                var parsedvar = CR2WTypeManager.Create(ClassName.Value, "", cr2w, Data);
                parsedvar.Read(file, size);


                Data.AddVariable(parsedvar);
            }


            //check
            var endpos = file.BaseStream.Position;
            var bytesread = endpos - startpos;
            if (bytesread != bytecount)
            {
                throw new InvalidParsingException($"Error in parsing SAppearanceAttachment: Data Variable. {bytesread} bytes read out of {bytecount}.");
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            byte[] buffer;
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                bw.WriteBit6(Data.elements.Count);
                foreach (var cvar in Data.elements)
                {
                    var ClassName = new CName(cr2w, null, "")
                    {
                        Value = cvar.REDType
                    };
                    ClassName.Write(bw);

                    cvar.Write(bw);
                }
                buffer = ms.ToArray();
            }

            file.Write(buffer.Length + 4);
            file.Write(buffer);
        }

    }
}
