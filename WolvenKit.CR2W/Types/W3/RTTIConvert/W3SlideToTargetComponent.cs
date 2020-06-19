using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SlideToTargetComponent : CSelfUpdatingComponent
	{
		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("stopDistance")] 		public CFloat StopDistance { get; set;}

		[RED("targetOffset")] 		public Vector TargetOffset { get; set;}

		[RED("fallBackSpeed")] 		public CFloat FallBackSpeed { get; set;}

		[RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		[RED("normalSpeed")] 		public CFloat NormalSpeed { get; set;}

		[RED("verticalSpeed")] 		public CFloat VerticalSpeed { get; set;}

		[RED("speedOscilation")] 		public SRangeF SpeedOscilation { get; set;}

		[RED("normalSpeedOscilation")] 		public SRangeF NormalSpeedOscilation { get; set;}

		[RED("verticalOscilation")] 		public SRangeF VerticalOscilation { get; set;}

		[RED("speedOscilationSpeed")] 		public CFloat SpeedOscilationSpeed { get; set;}

		[RED("normalSpeedOscilationSpeed")] 		public CFloat NormalSpeedOscilationSpeed { get; set;}

		[RED("verticalOscilationSpeed")] 		public CFloat VerticalOscilationSpeed { get; set;}

		[RED("gameplayEventAtDestination")] 		public CName GameplayEventAtDestination { get; set;}

		[RED("triggerGPEventOnTarget")] 		public CBool TriggerGPEventOnTarget { get; set;}

		[RED("destroyDelayAtDestination")] 		public CFloat DestroyDelayAtDestination { get; set;}

		[RED("stopEffectAtDest")] 		public CName StopEffectAtDest { get; set;}

		[RED("playEffectAtDest")] 		public CName PlayEffectAtDest { get; set;}

		[RED("stayAboveNavigableSpace")] 		public CBool StayAboveNavigableSpace { get; set;}

		[RED("considerSuccesAfterDelay")] 		public CFloat ConsiderSuccesAfterDelay { get; set;}

		public W3SlideToTargetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SlideToTargetComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}