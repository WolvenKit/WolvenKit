using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{

    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SWayPointsCollectionsSetData : CVariable
    {
        [RED] public CGUID Guid { get; set; }
        [RED] public CHandle<CWayPointsCollection> Handle { get; set; }

        public SWayPointsCollectionsSetData(CR2WFile cr2w) : base(cr2w)
        {
            Guid = new CGUID(cr2w);
            Handle = new CHandle<CWayPointsCollection>(cr2w);
        }

        public override CVariable Create(CR2WFile cr2w) => new SWayPointsCollectionsSetData(cr2w);
    }
}