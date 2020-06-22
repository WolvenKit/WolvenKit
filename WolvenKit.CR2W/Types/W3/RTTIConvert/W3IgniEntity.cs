using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IgniEntity : W3SignEntity
	{
		[RED("collisionFxEntity")] 		public CHandle<CEntity> CollisionFxEntity { get; set;}

		[RED("rangeFxEntity")] 		public CHandle<CEntity> RangeFxEntity { get; set;}

		[RED("channelBurnTestDT", 2,0)] 		public CArray<SIgniChannelDT> ChannelBurnTestDT { get; set;}

		[RED("lastCollisionFxPos")] 		public Vector LastCollisionFxPos { get; set;}

		[RED("CHANNELLING_BURN_TEST_FREQUENCY")] 		public CFloat CHANNELLING_BURN_TEST_FREQUENCY { get; set;}

		[RED("aspects", 2,0)] 		public CArray<SIgniAspect> Aspects { get; set;}

		[RED("effects", 2,0)] 		public CArray<SIgniEffects> Effects { get; set;}

		[RED("forestTrigger")] 		public CHandle<W3ForestTrigger> ForestTrigger { get; set;}

		[RED("projectileCollision", 2,0)] 		public CArray<CName> ProjectileCollision { get; set;}

		[RED("hitEntities", 2,0)] 		public CArray<CHandle<CGameplayEntity>> HitEntities { get; set;}

		[RED("lastFxSpawnTime")] 		public CFloat LastFxSpawnTime { get; set;}

		public W3IgniEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3IgniEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}