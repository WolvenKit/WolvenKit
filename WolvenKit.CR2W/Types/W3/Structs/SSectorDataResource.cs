using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using CsvHelper;
using System.Globalization;
using WolvenKit.Common.Model;
using WolvenKit.CR2W.Resources;
using RED.FNV1A;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CSectorDataResource : CVariable
    {
        public CFloat box0;
        public CFloat box1;
        public CFloat box2;
        public CFloat box3;
        public CFloat box4;
        public CFloat box5;
        //public CUInt64 patchHash;
        public CString pathHash;

        public CSectorDataResource(CR2WFile cr2w)
            : base(cr2w)
        {
            box0 = new CFloat(cr2w) { Name = "box0", Type = "Float" };
            box1 = new CFloat(cr2w) { Name = "box1", Type = "Float" };
            box2 = new CFloat(cr2w) { Name = "box2", Type = "Float" };
            box3 = new CFloat(cr2w) { Name = "box3", Type = "Float" };
            box4 = new CFloat(cr2w) { Name = "box4", Type = "Float" };
            box5 = new CFloat(cr2w) { Name = "box5", Type = "Float" };
            pathHash = new CString(cr2w) { Name = "pathHash" };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSectorDataResource(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            box0.Read(file, 4);
            box1.Read(file, 4);
            box2.Read(file, 4);
            box3.Read(file, 4);
            box4.Read(file, 4);
            box5.Read(file, 4);
            UInt64 hashint = file.ReadUInt64();

            // here for now until maincontroller is in Wkit.Common
            var hashdump = Cr2wResourceManager.Get().Hashdumplist.FirstOrDefault(_ => _.HashInt == hashint);
            pathHash.val = hashdump != null ? hashdump.Path : "";
        }

        public override void Write(BinaryWriter file)
        {
            box0.Write(file);
            box1.Write(file);
            box2.Write(file);
            box3.Write(file);
            box4.Write(file);
            box5.Write(file);

            // here for now until maincontroller is in Wkit.Common
            ulong hashint = 0;
            if (!string.IsNullOrEmpty(pathHash.val))
            {
                var hashdump = Cr2wResourceManager.Get().Hashdumplist.FirstOrDefault(_ => _.Path == pathHash.val);
                if (hashdump != null)
                    hashint = hashdump.HashInt;
                else
                    hashint = FNV1A64HashAlgorithm.HashString(pathHash.val);
            }

            file.Write(hashint);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                box0,
                box1,
                box2,
                box3,
                box4,
                box5,
                pathHash,
            };
        }

        public override string ToString()
        {
            return pathHash.ToString();
        }
    }
}