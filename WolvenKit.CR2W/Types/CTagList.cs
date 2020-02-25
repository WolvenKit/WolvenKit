using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CTagList : CVariable
    {
        public List<CName> tags = new List<CName>();

        public CTagList(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadBit6();

            for (var i = 0; i < count; i++)
            {
                var var = new CName(cr2w);
                var.Read(file, 0);
                AddVariable(var);
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((byte) tags.Count);
            for (var i = 0; i < tags.Count; i++)
            {
                tags[i].Write(file);
            }
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CTagList(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CTagList) base.Copy(context);

            foreach (var tag in tags)
            {
                var.AddVariable((CName) tag.Copy(context));
            }
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return tags.Cast<IEditableVariable>().ToList();
        }

        public override void AddVariable(CVariable var)
        {
            if (var is CName)
            {
                var tag = (CName) var;
                tags.Add(tag);
                tag.ParentVariable = this;
            }
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is CName;
        }

        public override bool CanRemoveVariable(IEditableVariable child)
        {
            if (child is CName)
            {
                var tag = (CName) child;
                return tags.Contains(tag);
            }

            return false;
        }

        public override void RemoveVariable(IEditableVariable child)
        {
            if (child is CName)
            {
                var tag = (CName) child;
                tags.Remove(tag);
                tag.ParentVariable = null;
            }
        }

        public override string ToString()
        {
            var list = new List<string>();
            foreach (var tag in tags)
            {
                list.Add(tag.Value);
            }
            return string.Join(", ", list);
        }
    }
}