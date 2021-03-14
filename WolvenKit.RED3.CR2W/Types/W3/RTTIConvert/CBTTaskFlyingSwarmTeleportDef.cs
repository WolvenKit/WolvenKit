using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyingSwarmTeleportDef : CBTTaskTeleportDef
	{
		[Ordinal(1)] [RED("useAnimations")] 		public CBool UseAnimations { get; set;}

		[Ordinal(2)] [RED("spawnedBirdCount")] 		public CInt32 SpawnedBirdCount { get; set;}

		[Ordinal(3)] [RED("delayVanish")] 		public CFloat DelayVanish { get; set;}

		[Ordinal(4)] [RED("forcedDespawnTime")] 		public CFloat ForcedDespawnTime { get; set;}

		[Ordinal(5)] [RED("appearFXLoopInterval")] 		public CFloat AppearFXLoopInterval { get; set;}

		[Ordinal(6)] [RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		public CBTTaskFlyingSwarmTeleportDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyingSwarmTeleportDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}