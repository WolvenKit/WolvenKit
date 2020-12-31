using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class TagList : CVariable
    {
        [RED] public CBufferVLQInt32<CName> tags { get; set; }

        public TagList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) {
            tags = new CBufferVLQInt32<CName>(cr2w, this, nameof(tags));
        }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadBit6();

            for (var i = 0; i < count; i++)
            {
                var var = new CName(cr2w, tags, i.ToString());
                var.Read(file, 0);
                AddVariable(var);
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.WriteBit6(tags.Count);
            for (var i = 0; i < tags.Count; i++)
            {
                tags[i].Write(file);
            }
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new TagList(cr2w, parent, name);
        }

        public override void AddVariable(CVariable var)
        {
            if (var is CName)
            {
                var tag = (CName) var;
                tags.Add(tag);
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

        public override bool RemoveVariable(IEditableVariable child)
        {
            if (child is CName)
            {
                var tag = (CName) child;
                tags.Remove(tag);
                return true;
            }
            return false;
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