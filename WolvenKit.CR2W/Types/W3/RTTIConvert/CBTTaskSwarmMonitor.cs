using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSwarmMonitor : IBehTreeTask
	{
		[RED("monitorShieldSwarm")] 		public CBool MonitorShieldSwarm { get; set;}

		[RED("respawnShieldBirds")] 		public CBool RespawnShieldBirds { get; set;}

		[RED("respawnThreshold")] 		public CFloat RespawnThreshold { get; set;}

		[RED("respawnCooldown")] 		public CFloat RespawnCooldown { get; set;}

		[RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		[RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[RED("boidPOIComponents", 2,0)] 		public CArray<CHandle<CComponent>> BoidPOIComponents { get; set;}

		public CBTTaskSwarmMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSwarmMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}