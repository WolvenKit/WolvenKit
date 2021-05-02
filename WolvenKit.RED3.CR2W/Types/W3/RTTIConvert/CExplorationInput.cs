using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationInput : CObject
	{
		[Ordinal(1)] [RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(2)] [RED("m_InputMoveOnPadV")] 		public Vector M_InputMoveOnPadV { get; set;}

		[Ordinal(3)] [RED("m_InputMoveOnPlaneV")] 		public Vector M_InputMoveOnPlaneV { get; set;}

		[Ordinal(4)] [RED("m_InputMoveOnPadNormalizedV")] 		public Vector M_InputMoveOnPadNormalizedV { get; set;}

		[Ordinal(5)] [RED("m_InputMoveOnPlaneNormalizedV")] 		public Vector M_InputMoveOnPlaneNormalizedV { get; set;}

		[Ordinal(6)] [RED("m_InputMoveOnCameraNormalizedV")] 		public Vector M_InputMoveOnCameraNormalizedV { get; set;}

		[Ordinal(7)] [RED("m_InputMoveDiffOnHeadingF")] 		public CFloat M_InputMoveDiffOnHeadingF { get; set;}

		[Ordinal(8)] [RED("m_InputMoveHeadingOnPlaneF")] 		public CFloat M_InputMoveHeadingOnPlaneF { get; set;}

		[Ordinal(9)] [RED("m_InputModuleF")] 		public CFloat M_InputModuleF { get; set;}

		[Ordinal(10)] [RED("m_InputMinModuleF")] 		public CFloat M_InputMinModuleF { get; set;}

		[Ordinal(11)] [RED("m_InputRunModuleF")] 		public CFloat M_InputRunModuleF { get; set;}

		[Ordinal(12)] [RED("m_InputHeadingDifMaxF")] 		public CFloat M_InputHeadingDifMaxF { get; set;}

		[Ordinal(13)] [RED("m_InputHeadingDifReflectedF")] 		public CFloat M_InputHeadingDifReflectedF { get; set;}

		[Ordinal(14)] [RED("m_JumpTimeGapF")] 		public CFloat M_JumpTimeGapF { get; set;}

		[Ordinal(15)] [RED("m_RollTimePrevF")] 		public CFloat M_RollTimePrevF { get; set;}

		[Ordinal(16)] [RED("m_InputDoubleTapPressValF")] 		public CFloat M_InputDoubleTapPressValF { get; set;}

		[Ordinal(17)] [RED("m_InputDoubleTapUnPressValF")] 		public CFloat M_InputDoubleTapUnPressValF { get; set;}

		[Ordinal(18)] [RED("m_InputDoubleTapTimeGapF")] 		public CFloat M_InputDoubleTapTimeGapF { get; set;}

		[Ordinal(19)] [RED("m_UseDoubleTapOnAxisB")] 		public CBool M_UseDoubleTapOnAxisB { get; set;}

		[Ordinal(20)] [RED("m_InputLeftO")] 		public CHandle<CInputAxisDoubleTap> M_InputLeftO { get; set;}

		[Ordinal(21)] [RED("m_InputRightO")] 		public CHandle<CInputAxisDoubleTap> M_InputRightO { get; set;}

		[Ordinal(22)] [RED("m_InputDownO")] 		public CHandle<CInputAxisDoubleTap> M_InputDownO { get; set;}

		[Ordinal(23)] [RED("m_InputUpO")] 		public CHandle<CInputAxisDoubleTap> M_InputUpO { get; set;}

		[Ordinal(24)] [RED("m_SprintDoubletapO")] 		public CHandle<CInputAxisDoubleTap> M_SprintDoubletapO { get; set;}

		[Ordinal(25)] [RED("m_ActionJumpN")] 		public CName M_ActionJumpN { get; set;}

		[Ordinal(26)] [RED("m_ActionExplorationN")] 		public CName M_ActionExplorationN { get; set;}

		[Ordinal(27)] [RED("m_ActionInteractionN")] 		public CName M_ActionInteractionN { get; set;}

		[Ordinal(28)] [RED("m_ActionRollN")] 		public CName M_ActionRollN { get; set;}

		[Ordinal(29)] [RED("m_ActionSprintN")] 		public CName M_ActionSprintN { get; set;}

		[Ordinal(30)] [RED("m_ActionSkateJumpN")] 		public CName M_ActionSkateJumpN { get; set;}

		[Ordinal(31)] [RED("m_ActionDashN")] 		public CName M_ActionDashN { get; set;}

		[Ordinal(32)] [RED("m_ActionDriftN")] 		public CName M_ActionDriftN { get; set;}

		[Ordinal(33)] [RED("m_ActionAttackN")] 		public CName M_ActionAttackN { get; set;}

		[Ordinal(34)] [RED("m_ActionAttackAltN")] 		public CName M_ActionAttackAltN { get; set;}

		[Ordinal(35)] [RED("m_ActionParryN")] 		public CName M_ActionParryN { get; set;}

		[Ordinal(36)] [RED("m_SprintLastActivationTimeF")] 		public CFloat M_SprintLastActivationTimeF { get; set;}

		public CExplorationInput(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}