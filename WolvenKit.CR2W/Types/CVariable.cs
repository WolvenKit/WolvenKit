using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public abstract class CVariable : IEditableVariable
    {
        public CR2WFile cr2w;

        public CVariable(CR2WFile cr2w)
        {
            this.cr2w = cr2w;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort typeId
        {
            get { return (ushort) cr2w.GetStringIndex(Type, true); }
            set { Type = cr2w.strings[value].str; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort nameId
        {
            get { return (ushort) cr2w.GetStringIndex(Name, true); }
            set { Name = cr2w.strings[value].str; }
        }

        public CVariable ParentVariable { get; set; }

        public string FullName
        {
            get
            {
                var name = Name;
                var c = ParentVariable;
                while (c != null)
                {
                    name = c.Name + "/" + name;
                    c = c.ParentVariable;
                }
                return name;
            }
        }

        public CR2WFile CR2WOwner => cr2w;

        public string Name { get; set; }
        public string Type { get; set; }

        public virtual Control GetEditor()
        {
            return null;
        }

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            return null;
        }

        public virtual bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public virtual bool CanAddVariable(IEditableVariable newvar)
        {
            return false;
        }

        public virtual void RemoveVariable(IEditableVariable child)
        {
        }

        public virtual void AddVariable(CVariable var)
        {
        }

        public abstract void Read(BinaryReader file, uint size);
        public abstract void Write(BinaryWriter file);
        public abstract CVariable Create(CR2WFile cr2w);

        public virtual CVariable SetValue(object val)
        {
            return this;
        }

        public virtual CVariable Copy(CR2WCopyAction context)
        {
            var var = Create(context.DestinationFile);
            var.Type = Type;
            var.Name = Name;
            return var;
        }
    }
}