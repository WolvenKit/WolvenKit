using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{

    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SWayPointsCollectionsSetData : CVariable
    {
        [Ordinal(0)] [RED] public CGUID Guid { get; set; }
        [Ordinal(1)] [RED] public CHandle<CWayPointsCollection> Handle { get; set; }

        public SWayPointsCollectionsSetData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWayPointsCollectionsSetData(cr2w, parent, name);
    }
}