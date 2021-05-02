using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDash : IBehTreeTask
	{
		[Ordinal(1)] [RED("slideBehindTarget")] 		public CBool SlideBehindTarget { get; set;}

		[Ordinal(2)] [RED("destinationOffset")] 		public CFloat DestinationOffset { get; set;}

		[Ordinal(3)] [RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[Ordinal(4)] [RED("dealDamageOnContact")] 		public CBool DealDamageOnContact { get; set;}

		[Ordinal(5)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(6)] [RED("sideStepDist")] 		public CFloat SideStepDist { get; set;}

		[Ordinal(7)] [RED("sideStepHeadingOffset")] 		public CFloat SideStepHeadingOffset { get; set;}

		[Ordinal(8)] [RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[Ordinal(9)] [RED("sendRotationEventAboveDashDist")] 		public CFloat SendRotationEventAboveDashDist { get; set;}

		[Ordinal(10)] [RED("isSliding")] 		public CBool IsSliding { get; set;}

		[Ordinal(11)] [RED("hitEntities", 2,0)] 		public CArray<CHandle<CEntity>> HitEntities { get; set;}

		[Ordinal(12)] [RED("collisionGroupsNames", 2,0)] 		public CArray<CName> CollisionGroupsNames { get; set;}

		public CBTTaskDash(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDash(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}