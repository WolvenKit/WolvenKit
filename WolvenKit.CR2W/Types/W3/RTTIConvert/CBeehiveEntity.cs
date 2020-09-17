using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBeehiveEntity : W3Container
	{
		[Ordinal(1)] [RED("damageVal")] 		public SAbilityAttributeValue DamageVal { get; set;}

		[Ordinal(2)] [RED("destroyEntAfter")] 		public CFloat DestroyEntAfter { get; set;}

		[Ordinal(3)] [RED("isFallingObject")] 		public CBool IsFallingObject { get; set;}

		[Ordinal(4)] [RED("desiredTargetTagForBeesSwarm")] 		public CName DesiredTargetTagForBeesSwarm { get; set;}

		[Ordinal(5)] [RED("excludedEntitiesTagsForBeeSwarm", 2,0)] 		public CArray<CName> ExcludedEntitiesTagsForBeeSwarm { get; set;}

		[Ordinal(6)] [RED("isOnFire")] 		public CBool IsOnFire { get; set;}

		[Ordinal(7)] [RED("hangingDamageArea")] 		public CHandle<CComponent> HangingDamageArea { get; set;}

		[Ordinal(8)] [RED("originPoint")] 		public Vector OriginPoint { get; set;}

		[Ordinal(9)] [RED("actorsInHangArea", 2,0)] 		public CArray<CHandle<CActor>> ActorsInHangArea { get; set;}

		[Ordinal(10)] [RED("hangingBuffParams")] 		public SCustomEffectParams HangingBuffParams { get; set;}

		[Ordinal(11)] [RED("beesActivated")] 		public CBool BeesActivated { get; set;}

		[Ordinal(12)] [RED("activeMovingBees")] 		public CHandle<W3BeeSwarm> ActiveMovingBees { get; set;}

		[Ordinal(13)] [RED("activeAttachedBees")] 		public CHandle<W3BeeSwarm> ActiveAttachedBees { get; set;}

		[Ordinal(14)] [RED("HANGING_AREA_NAME")] 		public CName HANGING_AREA_NAME { get; set;}

		public CBeehiveEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBeehiveEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}