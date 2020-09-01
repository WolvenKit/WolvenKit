using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SlideToTargetComponent : CSelfUpdatingComponent
	{
		[Ordinal(0)] [RED("("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(0)] [RED("("stopDistance")] 		public CFloat StopDistance { get; set;}

		[Ordinal(0)] [RED("("targetOffset")] 		public Vector TargetOffset { get; set;}

		[Ordinal(0)] [RED("("fallBackSpeed")] 		public CFloat FallBackSpeed { get; set;}

		[Ordinal(0)] [RED("("snapToGround")] 		public CBool SnapToGround { get; set;}

		[Ordinal(0)] [RED("("normalSpeed")] 		public CFloat NormalSpeed { get; set;}

		[Ordinal(0)] [RED("("verticalSpeed")] 		public CFloat VerticalSpeed { get; set;}

		[Ordinal(0)] [RED("("speedOscilation")] 		public SRangeF SpeedOscilation { get; set;}

		[Ordinal(0)] [RED("("normalSpeedOscilation")] 		public SRangeF NormalSpeedOscilation { get; set;}

		[Ordinal(0)] [RED("("verticalOscilation")] 		public SRangeF VerticalOscilation { get; set;}

		[Ordinal(0)] [RED("("speedOscilationSpeed")] 		public CFloat SpeedOscilationSpeed { get; set;}

		[Ordinal(0)] [RED("("normalSpeedOscilationSpeed")] 		public CFloat NormalSpeedOscilationSpeed { get; set;}

		[Ordinal(0)] [RED("("verticalOscilationSpeed")] 		public CFloat VerticalOscilationSpeed { get; set;}

		[Ordinal(0)] [RED("("gameplayEventAtDestination")] 		public CName GameplayEventAtDestination { get; set;}

		[Ordinal(0)] [RED("("triggerGPEventOnTarget")] 		public CBool TriggerGPEventOnTarget { get; set;}

		[Ordinal(0)] [RED("("destroyDelayAtDestination")] 		public CFloat DestroyDelayAtDestination { get; set;}

		[Ordinal(0)] [RED("("stopEffectAtDest")] 		public CName StopEffectAtDest { get; set;}

		[Ordinal(0)] [RED("("playEffectAtDest")] 		public CName PlayEffectAtDest { get; set;}

		[Ordinal(0)] [RED("("stayAboveNavigableSpace")] 		public CBool StayAboveNavigableSpace { get; set;}

		[Ordinal(0)] [RED("("considerSuccesAfterDelay")] 		public CFloat ConsiderSuccesAfterDelay { get; set;}

		[Ordinal(0)] [RED("("m_NodeTarget")] 		public CHandle<CNode> M_NodeTarget { get; set;}

		[Ordinal(0)] [RED("("m_VectorTarget")] 		public Vector M_VectorTarget { get; set;}

		[Ordinal(0)] [RED("("m_IsFallingBack")] 		public CBool M_IsFallingBack { get; set;}

		[Ordinal(0)] [RED("("m_Entity")] 		public CHandle<CEntity> M_Entity { get; set;}

		[Ordinal(0)] [RED("("m_CanSendEvent")] 		public CBool M_CanSendEvent { get; set;}

		[Ordinal(0)] [RED("("m_TimeBeforeSuccess")] 		public CFloat M_TimeBeforeSuccess { get; set;}

		[Ordinal(0)] [RED("("m_speedTarget")] 		public CFloat M_speedTarget { get; set;}

		[Ordinal(0)] [RED("("m_normalSpeedTarget")] 		public CFloat M_normalSpeedTarget { get; set;}

		[Ordinal(0)] [RED("("m_verticalOffsetTarget")] 		public CFloat M_verticalOffsetTarget { get; set;}

		[Ordinal(0)] [RED("("m_currentSpeedOsc")] 		public CFloat M_currentSpeedOsc { get; set;}

		[Ordinal(0)] [RED("("m_currentNormalSpeedOsc")] 		public CFloat M_currentNormalSpeedOsc { get; set;}

		[Ordinal(0)] [RED("("m_currentVertOffest")] 		public CFloat M_currentVertOffest { get; set;}

		public W3SlideToTargetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SlideToTargetComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}