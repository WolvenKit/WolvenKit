using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphDirectionalMovementNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("groupCount")] 		public CInt32 GroupCount { get; set;}

		[Ordinal(2)] [RED("animsPerGroup")] 		public CInt32 AnimsPerGroup { get; set;}

		[Ordinal(3)] [RED("firstGroupDirOffset")] 		public CFloat FirstGroupDirOffset { get; set;}

		[Ordinal(4)] [RED("extraOverlapAngle")] 		public CFloat ExtraOverlapAngle { get; set;}

		[Ordinal(5)] [RED("keepInCurrentGroupAngle")] 		public CFloat KeepInCurrentGroupAngle { get; set;}

		[Ordinal(6)] [RED("findGroupDirOffset")] 		public CFloat FindGroupDirOffset { get; set;}

		[Ordinal(7)] [RED("singleAnimOnly")] 		public CBool SingleAnimOnly { get; set;}

		[Ordinal(8)] [RED("doNotSwitchAnim")] 		public CBool DoNotSwitchAnim { get; set;}

		[Ordinal(9)] [RED("movementDirBlendTime")] 		public CFloat MovementDirBlendTime { get; set;}

		[Ordinal(10)] [RED("movementDirMaxSpeedChange")] 		public CFloat MovementDirMaxSpeedChange { get; set;}

		[Ordinal(11)] [RED("groupsBlendTime")] 		public CFloat GroupsBlendTime { get; set;}

		[Ordinal(12)] [RED("quickTurnBlendTime")] 		public CFloat QuickTurnBlendTime { get; set;}

		[Ordinal(13)] [RED("fasterQuickTurnBlendTime")] 		public CFloat FasterQuickTurnBlendTime { get; set;}

		[Ordinal(14)] [RED("angleThresholdForQuickTurn")] 		public CFloat AngleThresholdForQuickTurn { get; set;}

		[Ordinal(15)] [RED("reverseSyncOnQuickTurnFwdBwd")] 		public CBool ReverseSyncOnQuickTurnFwdBwd { get; set;}

		[Ordinal(16)] [RED("reverseSyncOnQuickTurnLeftRight")] 		public CBool ReverseSyncOnQuickTurnLeftRight { get; set;}

		[Ordinal(17)] [RED("syncBlendingOffsetPTLOnQuickTurn")] 		public CFloat SyncBlendingOffsetPTLOnQuickTurn { get; set;}

		[Ordinal(18)] [RED("startPTLRightFootInFront")] 		public CFloat StartPTLRightFootInFront { get; set;}

		[Ordinal(19)] [RED("startPTLLeftFootInFront")] 		public CFloat StartPTLLeftFootInFront { get; set;}

		[Ordinal(20)] [RED("alwaysStartAtZero")] 		public CBool AlwaysStartAtZero { get; set;}

		[Ordinal(21)] [RED("useSimpleBlendForMovementDelta")] 		public CBool UseSimpleBlendForMovementDelta { get; set;}

		[Ordinal(22)] [RED("useDefinedVariablesAsRequestedInput")] 		public CBool UseDefinedVariablesAsRequestedInput { get; set;}

		[Ordinal(23)] [RED("requestedMovementDirectionVariableName")] 		public CName RequestedMovementDirectionVariableName { get; set;}

		[Ordinal(24)] [RED("requestedFacingDirectionVariableName")] 		public CName RequestedFacingDirectionVariableName { get; set;}

		[Ordinal(25)] [RED("useDefinedInternalVariablesAsInitialInput")] 		public CBool UseDefinedInternalVariablesAsInitialInput { get; set;}

		[Ordinal(26)] [RED("movementDirectionInternalVariableName")] 		public CName MovementDirectionInternalVariableName { get; set;}

		[Ordinal(27)] [RED("groupDirInternalVariableName")] 		public CName GroupDirInternalVariableName { get; set;}

		[Ordinal(28)] [RED("loopCount")] 		public CInt32 LoopCount { get; set;}

		[Ordinal(29)] [RED("syncGroupOffsetPTL")] 		public CFloat SyncGroupOffsetPTL { get; set;}

		[Ordinal(30)] [RED("Right foot bone name")] 		public CName Right_foot_bone_name { get; set;}

		[Ordinal(31)] [RED("Left foot bone name")] 		public CName Left_foot_bone_name { get; set;}

		[Ordinal(32)] [RED("groupDir")] 		public CFloat GroupDir { get; set;}

		[Ordinal(33)] [RED("sideAngleRange")] 		public CFloat SideAngleRange { get; set;}

		[Ordinal(34)] [RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(35)] [RED("allInputsValid")] 		public CBool AllInputsValid { get; set;}

		[Ordinal(36)] [RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[Ordinal(37)] [RED("cachedRequestedMovementDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedMovementDirectionWSValueNode { get; set;}

		[Ordinal(38)] [RED("cachedRequestedFacingDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedFacingDirectionWSValueNode { get; set;}

		[Ordinal(39)] [RED("cachedInitialMovementDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedInitialMovementDirectionWSValueNode { get; set;}

		[Ordinal(40)] [RED("cachedInitialGroupDirMSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedInitialGroupDirMSValueNode { get; set;}

		public CBehaviorGraphDirectionalMovementNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphDirectionalMovementNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}