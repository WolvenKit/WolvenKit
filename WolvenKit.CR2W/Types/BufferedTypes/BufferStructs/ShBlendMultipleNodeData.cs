using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    public class ShBlendMultipleNodeData : CVariable
    {
        [RED] public CUInt32 index { get; set; }
        [RED] public CFloat blendvalue { get; set; }

        public ShBlendMultipleNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ShBlendMultipleNodeData(cr2w, parent, name);
    }





}