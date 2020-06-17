using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class SAppearanceAttachment : CVector
    {
        public CBufferVLQ<CVector> Data { get; set; }

        public SAppearanceAttachment(CR2WFile cr2w)
            : base(cr2w)
        {
            Data = new CBufferVLQ<CVector>(cr2w, _ => new CVector(_)) { Name = "Data" };
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
                var ClassName = new CName(cr2w);
                ClassName.Read(file, 2);

                var parsedvar = CR2WTypeManager.Get().GetByName(ClassName.Value, "", cr2w);
                parsedvar.Read(file, size);
                parsedvar.Type = ClassName.Value;
                

                Data.AddVariable(parsedvar);
                parsedvar.Name = ClassName.Value;
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
                    var ClassName = new CName(cr2w)
                    {
                        Value = cvar.Type
                    };
                    ClassName.Write(bw);

                    cvar.Write(bw);
                }
                buffer = ms.ToArray();
            }

            file.Write(buffer.Length + 4);
            file.Write(buffer);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SAppearanceAttachment(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SAppearanceAttachment) base.Copy(context);
            var.Data = (CBufferVLQ<CVector>) Data.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                Data
            };
            return list;
        }
    }
}