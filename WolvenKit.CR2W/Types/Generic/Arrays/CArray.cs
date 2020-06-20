using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using WolvenKit.CR2W.Editors;
using System.Linq;
using WolvenKit.CR2W.Reflection;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WolvenKit.CR2W.Types
{
    public interface IArrayAccessor : IEditableVariable
    {
        List<int> Flags { get; set; }

        string GetElementType();
    }

    public interface IArrayAccessor<T> : IArrayAccessor
    {
        List<T> elements { get; set; }
    }

    [REDMeta()]
    public class CArray<T> : CArrayBase<T>, IArrayAccessor<T> where T : CVariable
    {

        public CArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size, (int)file.ReadUInt32());
        }


        public override void Write(BinaryWriter file)
        {
            CUInt32 count = new CUInt32(cr2w, null, "")
            {
                val = (uint)elements.Count
            };
            count.Write(file);

            foreach (var element in elements)
            {
                element.Write(file);
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CArray<T>;

            foreach (var element in elements)
            {
                copy.elements.Add(element.Copy(context) as T);
            }

            return copy;
        }

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CArray<T>(cr2w, parent, name);
        }

        public string GetElementType()
        {
            return REDReflection.GetREDTypeString(typeof(T));
        }
    }
}