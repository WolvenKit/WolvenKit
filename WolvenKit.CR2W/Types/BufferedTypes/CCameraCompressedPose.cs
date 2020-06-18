using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CCameraCompressedPose : CDefaultCompressedPose2
    {
        [RED("tracks", 2, 0)] public CArray<CFloat> Tracks { get; set; }

        [REDBuffer] public CBytes bytes1 { get; set; }
        [REDBuffer] public CFloat float1 { get; set; }
        [REDBuffer] public CFloat float2 { get; set; }
        [REDBuffer] public CBytes bytes2 { get; set; }

        public CCameraCompressedPose(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCameraCompressedPose(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
               
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

        }

       

        public override string ToString()
        {
            return "";
        }
        
    }
}