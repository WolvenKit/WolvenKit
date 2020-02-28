using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Linq;
using WolvenKit.CR2W.Types.Utils;

namespace WolvenKit.CR2W.Types
{
    public class CEntity : CVector
    {
        
        public CUInt32 unk1;
        public CUInt32 unk2;

        public CArray components { get; set; }
        public CVector buffer_v1 { get; set; }
        public CArray buffer_v2 { get; set; }

        private bool isCreatedFromTemplate;
            
        public CEntity(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CUInt32(cr2w)
            {
                Name = "unk1"
            };
            unk2 = new CUInt32(cr2w)
            {
                Name = "unk2"
            };

            buffer_v1 = new CVector(cr2w)
            {
                Name = "Buffer_v1"
            };
            buffer_v2 = new CArray("", "CBufferType2", true, cr2w)
            {
                Name = "Buffer_v2"
            };

            components = new CArray("[]handle:Component", "handle:Component", true, cr2w);
            components.Name = "components";
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;

            base.Read(file, size);

            // check if created from template
            isCreatedFromTemplate = variables.FirstOrDefault(_ => _.Name == "template") != null;

            unk1.Read(file, 0);
            unk2.Read(file, 0);

            // Read Component Array (should only be present if NOT created from template)
            #region Componentsarray
            var endPos = file.BaseStream.Position;
            var bytesleft = size - (endPos - startPos);
            if (!isCreatedFromTemplate)
            {
                if (bytesleft > 0)
                {
                    var elementcount = file.ReadBit6();
                    for (var i = 0; i < elementcount; i++)
                    {
                        var handle = new CHandle(cr2w);
                        handle.Read(file, 0);
                        components.AddVariable(handle);
                    }
                }
                else
                {
                    throw new EndOfStreamException("unknown CEntity Fileformat.");
                }
            }
            #endregion


            // Read Buffer 1 (always)
            #region Buffer 1
            endPos = file.BaseStream.Position;
            bytesleft = size - (endPos - startPos);
            if (bytesleft > 0)
            {
                bool canRead;
                do
                {
                    var t_buffer = new CBufferType1(cr2w)
                    {
                        Name = "",
                    };
                    canRead = t_buffer.CanRead(file);
                    if (canRead)
                        t_buffer.Read(file, 0);
                    
                    buffer_v1.AddVariable(t_buffer);

                } while (canRead);
            }
            else
            {
                throw new EndOfStreamException("unknown CEntity Fileformat.");
            }
            #endregion

            // Read Buffer 2 (should only be present if created from template)
            #region Buffer 2
            endPos = file.BaseStream.Position;
            bytesleft = size - (endPos - startPos);
            if (isCreatedFromTemplate)
            {
                if (bytesleft > 0)
                {
                    buffer_v2.Read(file, 0);
                }
                else
                {
                    throw new EndOfStreamException("unknown CEntity Fileformat.");
                }
            }
            #endregion

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            // check if created from template
            isCreatedFromTemplate = variables.FirstOrDefault(_ => _.Name == "template") != null;

            unk1.Write(file);
            unk2.Write(file);

            // Write componentsarray (if not created from template)
            if (!isCreatedFromTemplate)
            {
                file.WriteBit6(components.array.Count);
                for (var i = 0; i < components.array.Count; i++)
                {
                    components.array[i].Write(file);
                }
            }

            // Write Buffer 1 (always)
            foreach (var n in buffer_v1.variables)
            {
                n.Write(file);
            }

            // Write Buffer 2 (if created from template)
            if (isCreatedFromTemplate)
                buffer_v2.Write(file);

        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CEntity(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CEntity) base.Copy(context);

            var.unk1 = (CUInt32) unk1.Copy(context);
            var.unk2 = (CUInt32) unk2.Copy(context);
            var.components = (CArray) components.Copy(context);
            var.buffer_v1 = buffer_v1;
            var.buffer_v2 = buffer_v2;

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);

            list.Add(unk1);
            list.Add(unk2);

            list.Add(components);
            list.Add(buffer_v1);
            list.Add(buffer_v2);

            return list;
        }
    }
}