using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;

namespace WolvenKit.CR2W.Types
{


    public class CWayPointsCollectionsSetData : CVariable
    {
        public CGUID guid;
        public CHandle handle;


        public CWayPointsCollectionsSetData(CR2WFile cr2w) :
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

        public override CVariable SetValue(object val) => this;

        public override CVariable Create(CR2WFile cr2w) => new CWayPointsCollectionsSetData(cr2w);

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CWayPointsCollectionsSetData)base.Copy(context);
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


    public class CWayPointsCollectionsSet : CVector
    {
        public CArray waypointcollections;
        
        public CWayPointsCollectionsSet(CR2WFile cr2w) :
            base(cr2w)
        {
            waypointcollections = new CArray("[]CWayPointsCollectionsSetData", "CWayPointsCollectionsSetData", true, cr2w)
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

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CWayPointsCollectionsSet(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CWayPointsCollectionsSet) base.Copy(context);

            var.waypointcollections = waypointcollections;

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