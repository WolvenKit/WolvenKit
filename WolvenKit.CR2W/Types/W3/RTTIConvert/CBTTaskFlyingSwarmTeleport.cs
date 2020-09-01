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
		[Ordinal(0)] [RED("("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[Ordinal(0)] [RED("("useAnimations")] 		public CBool UseAnimations { get; set;}

		[Ordinal(0)] [RED("("attackTeleport")] 		public CBool AttackTeleport { get; set;}

		[Ordinal(0)] [RED("("res")] 		public CBool Res { get; set;}

		[Ordinal(0)] [RED("("fail")] 		public CBool Fail { get; set;}

		[Ordinal(0)] [RED("("despawnCalled")] 		public CBool DespawnCalled { get; set;}

		[Ordinal(0)] [RED("("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		[Ordinal(0)] [RED("("delayVanish")] 		public CFloat DelayVanish { get; set;}

		[Ordinal(0)] [RED("("fxTime")] 		public CFloat FxTime { get; set;}

		[Ordinal(0)] [RED("("spawnedBirdCount")] 		public CInt32 SpawnedBirdCount { get; set;}

		[Ordinal(0)] [RED("("boidPOIComponents", 2,0)] 		public CArray<CHandle<CComponent>> BoidPOIComponents { get; set;}

		[Ordinal(0)] [RED("("appearFXLoopInterval")] 		public CFloat AppearFXLoopInterval { get; set;}

		[Ordinal(0)] [RED("("forcedDespawnTime")] 		public CFloat ForcedDespawnTime { get; set;}

		public CBTTaskFlyingSwarmTeleport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyingSwarmTeleport(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}