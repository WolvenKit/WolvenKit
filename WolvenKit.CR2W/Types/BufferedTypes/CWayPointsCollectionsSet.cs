using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CWayPointsCollectionsSet : CResource
    {
        [REDBuffer] public CBufferUInt32<SWayPointsCollectionsSetData> waypointcollections { get; set; }
        
        public CWayPointsCollectionsSet(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CWayPointsCollectionsSet(cr2w);
        }
    }
}