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

		[RED("m_NodeTarget")] 		public CHandle<CNode> M_NodeTarget { get; set;}

		[RED("m_VectorTarget")] 		public Vector M_VectorTarget { get; set;}

		[RED("m_IsFallingBack")] 		public CBool M_IsFallingBack { get; set;}

		[RED("m_Entity")] 		public CHandle<CEntity> M_Entity { get; set;}

		[RED("m_CanSendEvent")] 		public CBool M_CanSendEvent { get; set;}

		[RED("m_TimeBeforeSuccess")] 		public CFloat M_TimeBeforeSuccess { get; set;}

		[RED("m_speedTarget")] 		public CFloat M_speedTarget { get; set;}

		[RED("m_normalSpeedTarget")] 		public CFloat M_normalSpeedTarget { get; set;}

		[RED("m_verticalOffsetTarget")] 		public CFloat M_verticalOffsetTarget { get; set;}

		[RED("m_currentSpeedOsc")] 		public CFloat M_currentSpeedOsc { get; set;}

		[RED("m_currentNormalSpeedOsc")] 		public CFloat M_currentNormalSpeedOsc { get; set;}

		[RED("m_currentVertOffest")] 		public CFloat M_currentVertOffest { get; set;}

		public W3SlideToTargetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SlideToTargetComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}