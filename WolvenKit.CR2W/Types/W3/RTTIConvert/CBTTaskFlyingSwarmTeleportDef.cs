using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyingSwarmTeleportDef : CBTTaskTeleportDef
	{
		[RED("useAnimations")] 		public CBool UseAnimations { get; set;}

		[RED("spawnedBirdCount")] 		public CInt32 SpawnedBirdCount { get; set;}

		[RED("delayVanish")] 		public CFloat DelayVanish { get; set;}

		[RED("forcedDespawnTime")] 		public CFloat ForcedDespawnTime { get; set;}

		[RED("appearFXLoopInterval")] 		public CFloat AppearFXLoopInterval { get; set;}

		[RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		public CBTTaskFlyingSwarmTeleportDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyingSwarmTeleportDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}