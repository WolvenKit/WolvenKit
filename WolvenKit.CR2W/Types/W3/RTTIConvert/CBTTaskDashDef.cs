using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskDashDef : IBehTreeTaskDefinition
	{
		[RED("slideBehindTarget")] 		public CBool SlideBehindTarget { get; set;}

		[RED("destinationOffset")] 		public CFloat DestinationOffset { get; set;}

		[RED("disableCollision")] 		public CBool DisableCollision { get; set;}

		[RED("dealDamageOnContact")] 		public CBool DealDamageOnContact { get; set;}

		[RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[RED("sideStepDist")] 		public CFloat SideStepDist { get; set;}

		[RED("sideStepHeadingOffset")] 		public CFloat SideStepHeadingOffset { get; set;}

		[RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[RED("sendRotationEventAboveDashDist")] 		public CFloat SendRotationEventAboveDashDist { get; set;}

		public CBTTaskDashDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskDashDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}