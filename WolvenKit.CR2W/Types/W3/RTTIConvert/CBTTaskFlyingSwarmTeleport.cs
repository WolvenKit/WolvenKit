using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyingSwarmTeleport : CBTTaskTeleport
	{
		[RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[RED("useAnimations")] 		public CBool UseAnimations { get; set;}

		[RED("attackTeleport")] 		public CBool AttackTeleport { get; set;}

		[RED("res")] 		public CBool Res { get; set;}

		[RED("fail")] 		public CBool Fail { get; set;}

		[RED("despawnCalled")] 		public CBool DespawnCalled { get; set;}

		[RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		[RED("delayVanish")] 		public CFloat DelayVanish { get; set;}

		[RED("fxTime")] 		public CFloat FxTime { get; set;}

		[RED("spawnedBirdCount")] 		public CInt32 SpawnedBirdCount { get; set;}

		[RED("boidPOIComponents", 2,0)] 		public CArray<CHandle<CComponent>> BoidPOIComponents { get; set;}

		[RED("appearFXLoopInterval")] 		public CFloat AppearFXLoopInterval { get; set;}

		[RED("forcedDespawnTime")] 		public CFloat ForcedDespawnTime { get; set;}

		public CBTTaskFlyingSwarmTeleport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyingSwarmTeleport(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}