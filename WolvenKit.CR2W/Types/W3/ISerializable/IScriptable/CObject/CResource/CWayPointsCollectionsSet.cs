using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{

    [DataContract(Namespace = "")]
    public class SWayPointsCollectionsSetData : CVariable
    {
        public CGUID guid;
        public CHandle handle;


        public SWayPointsCollectionsSetData(CR2WFile cr2w) :
            base(cr2w)
        {
            guid = new CGUID(cr2w)
            {
                Name = "guid"
            };
            handle = new CHandle(cr2w)
            {
                Name = "handle"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            guid.Read(file, 16);
            handle.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            guid.Write(file);
            handle.Write(file);
        }


        public override CVariable Create(CR2WFile cr2w) => new SWayPointsCollectionsSetData(cr2w);

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SWayPointsCollectionsSetData)base.Copy(context);
            var.guid = guid;
            var.handle = handle;

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                guid,
                handle
            };
        }

        public override string ToString()
        {
            return "";
        }
    }


    [DataContract(Namespace = "")]
    public class CWayPointsCollectionsSet : CVector
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

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                waypointcollections
            };
        }
    }
}