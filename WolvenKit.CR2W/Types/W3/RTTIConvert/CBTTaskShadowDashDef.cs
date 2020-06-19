using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskShadowDashDef : IBehTreeTaskDefinition
	{
		[RED("slideSpeed")] 		public CFloat SlideSpeed { get; set;}

		[RED("slideBehindTarget")] 		public CBool SlideBehindTarget { get; set;}

		[RED("distanceOffset")] 		public CFloat DistanceOffset { get; set;}

		[RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[RED("dealDamageOnContact")] 		public CBool DealDamageOnContact { get; set;}

		[RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[RED("maxDist")] 		public CFloat MaxDist { get; set;}

		[RED("sideStepDist")] 		public CFloat SideStepDist { get; set;}

		[RED("sideStepHeadingOffset")] 		public CFloat SideStepHeadingOffset { get; set;}

		[RED("minDuration")] 		public CFloat MinDuration { get; set;}

		[RED("maxDuration")] 		public CFloat MaxDuration { get; set;}

		[RED("slideBlendInTime")] 		public CFloat SlideBlendInTime { get; set;}

		[RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		public CBTTaskShadowDashDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskShadowDashDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}