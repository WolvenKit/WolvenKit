using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using WolvenKit.RED3.CR2W.Types.Utils;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    public partial class CEntity : CNode
    {
        [Ordinal(1000)] [REDBuffer(true)] public CArray<CPtr<CComponent>> Components { get; set; }
        [Ordinal(1001)] [REDBuffer(true)] public CCompressedBuffer<SEntityBufferType1> BufferV1 { get; set; }
        [Ordinal(1002)] [REDBuffer(true)] public CBufferUInt32<SEntityBufferType2> BufferV2 { get; set; }

        private bool isCreatedFromTemplate;

        public CEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Components = new CArray<CPtr<CComponent>>(cr2w, this, nameof(Components)) {IsSerialized = true, Elementtype = "ptr:CComponent"};
            BufferV1 = new CCompressedBuffer<SEntityBufferType1>(cr2w, this, nameof(BufferV1)) { IsSerialized = true };
            BufferV2 = new CBufferUInt32<SEntityBufferType2>(cr2w, this, nameof(BufferV2)) { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startPos = file.BaseStream.Position;

            base.Read(file, size);

            // check if created from template
            isCreatedFromTemplate = this.Template != null && (this.Template.Reference != null || !string.IsNullOrEmpty(this.Template.DepotPath));

            // Read Component Array (should only be present if NOT created from template)
            #region Componentsarray

            //if (Components == null)
            //    Components = CR2WTypeManager.Create("array:2,0,ptr:CComponent", "Components", cr2w, this) as CArray<CPtr<CComponent>>;


            var endPos = file.BaseStream.Position;
            var bytesleft = size - (endPos - startPos);
            if (!isCreatedFromTemplate)
            {
                if (bytesleft > 0)
                {
                    Components.IsSerialized = true;
                    var elementcount = file.ReadBit6();
                    for (var i = 0; i < elementcount; i++)
                    {
                        var ptr = CR2WTypeManager.Create("ptr:CComponent", i.ToString(), cr2w, Components);
                        if (ptr is IPtrAccessor iptr)
                        {
                            ptr.IsSerialized = true;
                            ptr.Read(file, 0);
                            Components.AddVariable(ptr);
                        }

                    }
                }
                else
                {
                    throw new EndOfStreamException("Unknown CEntity file format.");
                }
            }
            #endregion


            // Read Buffer 1 (always)
            #region Buffer 1
            endPos = file.BaseStream.Position;
            bytesleft = size - (endPos - startPos);
            if (bytesleft > 0)
            {
                int idx = 0;
                bool canRead;
                do
                {
                    var t_buffer = new SEntityBufferType1(cr2w, BufferV1, idx.ToString()) { IsSerialized = true };
                    canRead = t_buffer.CanRead(file);
                    if (canRead)
                        t_buffer.Read(file, 0);

                    BufferV1.AddVariable(t_buffer);
                    idx++;
                } while (canRead);
            }
            else
            {
                throw new EndOfStreamException("Unknown CEntity file format.");
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
                    BufferV2.Read(file, 0);
                }
                else
                {
                    throw new EndOfStreamException("Unknown CEntity file format.");
                }
            }
            #endregion

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            // check if created from template
            isCreatedFromTemplate = this.Template != null && (this.Template.Reference != null || !string.IsNullOrEmpty(this.Template.DepotPath));

            // Write componentsarray (if not created from template)
            if (!isCreatedFromTemplate)
            {
                file.WriteBit6(Components.Count);
                for (var i = 0; i < Components.Count; i++)
                {
                    Components[i].Write(file);
                }
            }

            // Write Buffer 1 (always)
            if (BufferV1.Count > 0)
            {
                foreach (var buf in BufferV1)
                {
                    buf.Write(file);
                }
            }
            else
            {
                file.Write((ushort)0x0); //2 null bytes
            }

            // Write Buffer 2 (if created from template)
            if (isCreatedFromTemplate)
                BufferV2.Write(file);

        }
    }
}
