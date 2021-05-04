using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IgniEntity : W3SignEntity
	{
		[Ordinal(1)] [RED("collisionFxEntity")] 		public CHandle<CEntity> CollisionFxEntity { get; set;}

		[Ordinal(2)] [RED("rangeFxEntity")] 		public CHandle<CEntity> RangeFxEntity { get; set;}

		[Ordinal(3)] [RED("channelBurnTestDT", 2,0)] 		public CArray<SIgniChannelDT> ChannelBurnTestDT { get; set;}

		[Ordinal(4)] [RED("lastCollisionFxPos")] 		public Vector LastCollisionFxPos { get; set;}

		[Ordinal(5)] [RED("CHANNELLING_BURN_TEST_FREQUENCY")] 		public CFloat CHANNELLING_BURN_TEST_FREQUENCY { get; set;}

		[Ordinal(6)] [RED("aspects", 2,0)] 		public CArray<SIgniAspect> Aspects { get; set;}

		[Ordinal(7)] [RED("effects", 2,0)] 		public CArray<SIgniEffects> Effects { get; set;}

		[Ordinal(8)] [RED("forestTrigger")] 		public CHandle<W3ForestTrigger> ForestTrigger { get; set;}

		[Ordinal(9)] [RED("projectileCollision", 2,0)] 		public CArray<CName> ProjectileCollision { get; set;}

		[Ordinal(10)] [RED("hitEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> HitEntities { get; set;}

		[Ordinal(11)] [RED("lastFxSpawnTime")] 		public CFloat LastFxSpawnTime { get; set;}

		public W3IgniEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}