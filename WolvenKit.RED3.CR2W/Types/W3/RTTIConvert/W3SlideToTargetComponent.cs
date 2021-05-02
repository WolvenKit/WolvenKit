using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SlideToTargetComponent : CSelfUpdatingComponent
	{
		[Ordinal(1)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(2)] [RED("stopDistance")] 		public CFloat StopDistance { get; set;}

		[Ordinal(3)] [RED("targetOffset")] 		public Vector TargetOffset { get; set;}

		[Ordinal(4)] [RED("fallBackSpeed")] 		public CFloat FallBackSpeed { get; set;}

		[Ordinal(5)] [RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		[Ordinal(6)] [RED("normalSpeed")] 		public CFloat NormalSpeed { get; set;}

		[Ordinal(7)] [RED("verticalSpeed")] 		public CFloat VerticalSpeed { get; set;}

		[Ordinal(8)] [RED("speedOscilation")] 		public SRangeF SpeedOscilation { get; set;}

		[Ordinal(9)] [RED("normalSpeedOscilation")] 		public SRangeF NormalSpeedOscilation { get; set;}

		[Ordinal(10)] [RED("verticalOscilation")] 		public SRangeF VerticalOscilation { get; set;}

		[Ordinal(11)] [RED("speedOscilationSpeed")] 		public CFloat SpeedOscilationSpeed { get; set;}

		[Ordinal(12)] [RED("normalSpeedOscilationSpeed")] 		public CFloat NormalSpeedOscilationSpeed { get; set;}

		[Ordinal(13)] [RED("verticalOscilationSpeed")] 		public CFloat VerticalOscilationSpeed { get; set;}

		[Ordinal(14)] [RED("gameplayEventAtDestination")] 		public CName GameplayEventAtDestination { get; set;}

		[Ordinal(15)] [RED("triggerGPEventOnTarget")] 		public CBool TriggerGPEventOnTarget { get; set;}

		[Ordinal(16)] [RED("destroyDelayAtDestination")] 		public CFloat DestroyDelayAtDestination { get; set;}

		[Ordinal(17)] [RED("stopEffectAtDest")] 		public CName StopEffectAtDest { get; set;}

		[Ordinal(18)] [RED("playEffectAtDest")] 		public CName PlayEffectAtDest { get; set;}

		[Ordinal(19)] [RED("stayAboveNavigableSpace")] 		public CBool StayAboveNavigableSpace { get; set;}

		[Ordinal(20)] [RED("considerSuccesAfterDelay")] 		public CFloat ConsiderSuccesAfterDelay { get; set;}

		[Ordinal(21)] [RED("m_NodeTarget")] 		public CHandle<CNode> M_NodeTarget { get; set;}

		[Ordinal(22)] [RED("m_VectorTarget")] 		public Vector M_VectorTarget { get; set;}

		[Ordinal(23)] [RED("m_IsFallingBack")] 		public CBool M_IsFallingBack { get; set;}

		[Ordinal(24)] [RED("m_Entity")] 		public CHandle<CEntity> M_Entity { get; set;}

		[Ordinal(25)] [RED("m_CanSendEvent")] 		public CBool M_CanSendEvent { get; set;}

		[Ordinal(26)] [RED("m_TimeBeforeSuccess")] 		public CFloat M_TimeBeforeSuccess { get; set;}

		[Ordinal(27)] [RED("m_speedTarget")] 		public CFloat M_speedTarget { get; set;}

		[Ordinal(28)] [RED("m_normalSpeedTarget")] 		public CFloat M_normalSpeedTarget { get; set;}

		[Ordinal(29)] [RED("m_verticalOffsetTarget")] 		public CFloat M_verticalOffsetTarget { get; set;}

		[Ordinal(30)] [RED("m_currentSpeedOsc")] 		public CFloat M_currentSpeedOsc { get; set;}

		[Ordinal(31)] [RED("m_currentNormalSpeedOsc")] 		public CFloat M_currentNormalSpeedOsc { get; set;}

		[Ordinal(32)] [RED("m_currentVertOffest")] 		public CFloat M_currentVertOffest { get; set;}

		public W3SlideToTargetComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SlideToTargetComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}