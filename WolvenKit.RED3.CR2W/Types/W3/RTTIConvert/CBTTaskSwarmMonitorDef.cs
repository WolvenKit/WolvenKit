using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSwarmMonitorDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("monitorShieldSwarm")] 		public CBool MonitorShieldSwarm { get; set;}

		[Ordinal(2)] [RED("respawnShieldBirds")] 		public CBool RespawnShieldBirds { get; set;}

		[Ordinal(3)] [RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		[Ordinal(4)] [RED("respawnThreshold")] 		public CFloat RespawnThreshold { get; set;}

		[Ordinal(5)] [RED("respawnCooldown")] 		public CFloat RespawnCooldown { get; set;}

		public CBTTaskSwarmMonitorDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}