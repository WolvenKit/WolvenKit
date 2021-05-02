using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskShadowDashDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("slideSpeed")] 		public CFloat SlideSpeed { get; set;}

		[Ordinal(2)] [RED("slideBehindTarget")] 		public CBool SlideBehindTarget { get; set;}

		[Ordinal(3)] [RED("distanceOffset")] 		public CFloat DistanceOffset { get; set;}

		[Ordinal(4)] [RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[Ordinal(5)] [RED("dealDamageOnContact")] 		public CBool DealDamageOnContact { get; set;}

		[Ordinal(6)] [RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[Ordinal(7)] [RED("maxDist")] 		public CFloat MaxDist { get; set;}

		[Ordinal(8)] [RED("sideStepDist")] 		public CFloat SideStepDist { get; set;}

		[Ordinal(9)] [RED("sideStepHeadingOffset")] 		public CFloat SideStepHeadingOffset { get; set;}

		[Ordinal(10)] [RED("minDuration")] 		public CFloat MinDuration { get; set;}

		[Ordinal(11)] [RED("maxDuration")] 		public CFloat MaxDuration { get; set;}

		[Ordinal(12)] [RED("slideBlendInTime")] 		public CFloat SlideBlendInTime { get; set;}

		[Ordinal(13)] [RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		public CBTTaskShadowDashDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskShadowDashDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}