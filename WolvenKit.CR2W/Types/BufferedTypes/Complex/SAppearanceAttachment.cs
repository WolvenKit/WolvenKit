using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    public partial class SAppearanceAttachment : CVariable
    {

        [REDBuffer(true)] public CBufferVLQ<CVariable> Data { get; set; }

        public SAppearanceAttachment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Data = new CBufferVLQ<CVariable>(cr2w, this, nameof(Data));
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
                throw new InvalidParsingException($"Error in parsing SAppearanceAttachment: Data Variable. Bytes read: {bytesread} out of {bytecount}.");
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