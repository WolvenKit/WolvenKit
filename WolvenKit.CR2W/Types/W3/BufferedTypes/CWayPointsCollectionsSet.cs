using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CWayPointsCollectionsSet : CResource
    {
        public CBufferUInt32<SWayPointsCollectionsSetData> waypointcollections;
        
        public CWayPointsCollectionsSet(CR2WFile cr2w) :
            base(cr2w)
        {
            waypointcollections = new CBufferUInt32<SWayPointsCollectionsSetData>(cr2w, _ => new SWayPointsCollectionsSetData(_))
            {
                Name = "waypointcollections",
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            waypointcollections.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            waypointcollections.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CWayPointsCollectionsSet(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CWayPointsCollectionsSet) base.Copy(context);

            var.waypointcollections = (CBufferUInt32<SWayPointsCollectionsSetData>)waypointcollections.Copy(context);

            return var;
        }
    }
}