using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSwarmMonitorDef : IBehTreeTaskDefinition
	{
		[RED("monitorShieldSwarm")] 		public CBool MonitorShieldSwarm { get; set;}

		[RED("respawnShieldBirds")] 		public CBool RespawnShieldBirds { get; set;}

		[RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		[RED("respawnThreshold")] 		public CFloat RespawnThreshold { get; set;}

		[RED("respawnCooldown")] 		public CFloat RespawnCooldown { get; set;}

		public CBTTaskSwarmMonitorDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSwarmMonitorDef(cr2w);

	}
}