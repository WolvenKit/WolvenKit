using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W.Types
{
    /// <summary>
    /// A generic wrapper class for a single CVariable
    /// Format: [ushort typeID] [uint size] [byte[size] data]
    /// </summary>
    [REDMeta()]
    public class CVariant : CVariable, IREDVariant
    {
        public IEditableVariable Variant { get; set; }

        public CVariant(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override string REDType => "Variant";

        public override void Read(BinaryReader file, uint size)
        {
            var typeId = file.ReadUInt16();
            var typename = cr2w.Names[typeId].Str;

            var varsize = file.ReadUInt32() - 4;

            if (varsize > 0)
            {
                Variant = CR2WTypeManager.Create(typename, nameof(Variant), cr2w, this);
                Variant.Read(file, varsize);
                Variant.IsSerialized = true;
            }
            else
            {
                // do nothing I guess?
            }
        }

        public override void Write(BinaryWriter file)
        {
            if (Variant == null)
            {
                file.Write((ushort)0);
                file.Write((uint)4);
            }
            else
            {
                file.Write((Variant as CVariable).GettypeId());

                byte[] buffer = System.Array.Empty<byte>();
                using (var ms = new MemoryStream())
                using (var bw = new BinaryWriter(ms))
                {
                    Variant.Write(bw);
                    buffer = ms.ToArray();
                }
                file.Write(buffer.Length + 4);
                file.Write(buffer);
            }
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            //if (val is CVariable)
            //{
            //    Variant = (CVariable)val;
            //}
            /*else*/ if (val is CVariant cvar)
            {
                var context = new CR2WCopyAction()
                {
                    DestinationFile = this.cr2w,
                    Parent = this.ParentVar as CVariable
                };
                this.Variant = cvar.Variant.Copy(context);
            }

            return this;
        }

        public void SetVariant(IEditableVariable variant) => this.Variant = variant;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var copy = (CVariant) base.Copy(context);
            if (Variant != null)
                copy.Variant = Variant.Copy(context);
            return copy;
        }

        public override List<IEditableVariable> GetEditableVariables() => new() { Variant };

        public override string ToString()
        {
            return Variant != null ? Variant.ToString() : "";
        }
    }
}
