using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyingSwarmTeleport : CBTTaskTeleport
	{
		[Ordinal(1)] [RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[Ordinal(2)] [RED("useAnimations")] 		public CBool UseAnimations { get; set;}

		[Ordinal(3)] [RED("attackTeleport")] 		public CBool AttackTeleport { get; set;}

		[Ordinal(4)] [RED("res")] 		public CBool Res { get; set;}

		[Ordinal(5)] [RED("fail")] 		public CBool Fail { get; set;}

		[Ordinal(6)] [RED("despawnCalled")] 		public CBool DespawnCalled { get; set;}

		[Ordinal(7)] [RED("disableBoidPOIComponents")] 		public CBool DisableBoidPOIComponents { get; set;}

		[Ordinal(8)] [RED("delayVanish")] 		public CFloat DelayVanish { get; set;}

		[Ordinal(9)] [RED("fxTime")] 		public CFloat FxTime { get; set;}

		[Ordinal(10)] [RED("spawnedBirdCount")] 		public CInt32 SpawnedBirdCount { get; set;}

		[Ordinal(11)] [RED("boidPOIComponents", 2,0)] 		public CArray<CHandle<CComponent>> BoidPOIComponents { get; set;}

		[Ordinal(12)] [RED("appearFXLoopInterval")] 		public CFloat AppearFXLoopInterval { get; set;}

		[Ordinal(13)] [RED("forcedDespawnTime")] 		public CFloat ForcedDespawnTime { get; set;}

		public CBTTaskFlyingSwarmTeleport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyingSwarmTeleport(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}