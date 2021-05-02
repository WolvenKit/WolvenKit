using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSwarmMonitor : IBehTreeTask
	{
		[Ordinal(1)] [RED("monitorShieldSwarm")] 		public CBool MonitorShieldSwarm { get; set;}

		[Ordinal(2)] [RED("respawnShieldBirds")] 		public CBool RespawnShieldBirds { get; set;}

		[Ordinal(3)] [RED("respawnThreshold")] 		public CFloat RespawnThreshold { get; set;}

		[Ordinal(4)] [RED("respawnCooldown")] 		public CFloat RespawnCooldown { get; set;}

		[Ordinal(5)] [RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		[Ordinal(6)] [RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[Ordinal(7)] [RED("boidPOIComponents", 2,0)] 		public CArray<CHandle<CComponent>> BoidPOIComponents { get; set;}

		public CBTTaskSwarmMonitor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSwarmMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}