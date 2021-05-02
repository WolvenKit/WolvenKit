using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Globalization;
using WolvenKit.Common.Model;
using System.Reflection;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CSectorDataResource : CVariable
    {
        [Ordinal(0)] [RED] public CFloat box0 { get; set; }
        [Ordinal(1)] [RED] public CFloat box1 { get; set; }
        [Ordinal(2)] [RED] public CFloat box2 { get; set; }
        [Ordinal(3)] [RED] public CFloat box3 { get; set; }
        [Ordinal(4)] [RED] public CFloat box4 { get; set; }
        [Ordinal(5)] [RED] public CFloat box5 { get; set; }
        //public CUInt64 patchHash;
        [Ordinal(7)] [RED] public CString pathHash { get; set; }

        public CSectorDataResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            box0 = new CFloat(cr2w, this, nameof(box0)) { IsSerialized = true };
            box1 = new CFloat(cr2w, this, nameof(box1)) { IsSerialized = true };
            box2 = new CFloat(cr2w, this, nameof(box2)) { IsSerialized = true };
            box3 = new CFloat(cr2w, this, nameof(box3)) { IsSerialized = true };
            box4 = new CFloat(cr2w, this, nameof(box4)) { IsSerialized = true };
            box5 = new CFloat(cr2w, this, nameof(box5)) { IsSerialized = true };
            pathHash = new CString(cr2w, this, nameof(pathHash)) { IsSerialized = true };
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CSectorDataResource(cr2w, parent, name);
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
            if (hashint == 0)
                pathHash.val = "";
            else
            {
                // check for vanilla hashed paths
                if (Cr2wResourceManager.Get().HashdumpDict.ContainsValue(hashint))
                    pathHash.val = Cr2wResourceManager.Get().HashdumpDict.First(_ => _.Value == hashint).Key;
                else
                {
                    // check for custom hashed paths
                    if (Cr2wResourceManager.Get().CHashdumpDict.ContainsValue(hashint))
                        pathHash.val = Cr2wResourceManager.Get().CHashdumpDict.First(_ => _.Value == hashint).Key;
                    else
                        pathHash.val = $"#{hashint}";
                }
            }
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
            // awkward test for unrecognized custom hashes
            if (string.IsNullOrEmpty(pathHash.val))
                hashint = 0;
            else if (pathHash.val[0] == '#')
            {
                hashint = ulong.Parse(pathHash.val.TrimStart('#'));
            }
            else
            {
                //check if in game depot hashes
                if (Cr2wResourceManager.Get().HashdumpDict.ContainsKey(pathHash.val))
                    hashint = Cr2wResourceManager.Get().HashdumpDict[pathHash.val];
                else
                {
                    //check if in local custom hashes
                    if (Cr2wResourceManager.Get().CHashdumpDict.ContainsKey(pathHash.val))
                        hashint = Cr2wResourceManager.Get().CHashdumpDict[pathHash.val];
                    //hash new path and add to collection
                    else
                        hashint = Cr2wResourceManager.Get().RegisterAndWriteCustomPath(pathHash.val);
                }

            }
            file.Write(hashint);
        }

        public override string ToString()
        {
            return pathHash.ToString();
        }
    }
}