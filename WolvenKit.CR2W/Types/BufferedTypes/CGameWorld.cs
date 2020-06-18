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
    [REDMeta]
    public class CGameWorld : CWorld
    {
        [RED("cookedExplorations")] public CHandle<CCookedExplorations> CookedExplorations { get; set; }

        [RED("cookedWaypoints")] public CHandle<CWayPointsCollectionsSet> CookedWaypoints { get; set; }

        [REDBuffer] public CHandle<CLayerGroup> firstlayer { get; set; }

        public CGameWorld(CR2WFile cr2w) :
            base(cr2w)
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
            return new CGameWorld(cr2w);
        }


    }
}