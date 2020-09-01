using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphDirectionalMovementNode : CBehaviorGraphNode
	{
		[Ordinal(0)] [RED("("groupCount")] 		public CInt32 GroupCount { get; set;}

		[Ordinal(0)] [RED("("animsPerGroup")] 		public CInt32 AnimsPerGroup { get; set;}

		[Ordinal(0)] [RED("("firstGroupDirOffset")] 		public CFloat FirstGroupDirOffset { get; set;}

		[Ordinal(0)] [RED("("extraOverlapAngle")] 		public CFloat ExtraOverlapAngle { get; set;}

		[Ordinal(0)] [RED("("keepInCurrentGroupAngle")] 		public CFloat KeepInCurrentGroupAngle { get; set;}

		[Ordinal(0)] [RED("("findGroupDirOffset")] 		public CFloat FindGroupDirOffset { get; set;}

		[Ordinal(0)] [RED("("singleAnimOnly")] 		public CBool SingleAnimOnly { get; set;}

		[Ordinal(0)] [RED("("doNotSwitchAnim")] 		public CBool DoNotSwitchAnim { get; set;}

		[Ordinal(0)] [RED("("movementDirBlendTime")] 		public CFloat MovementDirBlendTime { get; set;}

		[Ordinal(0)] [RED("("movementDirMaxSpeedChange")] 		public CFloat MovementDirMaxSpeedChange { get; set;}

		[Ordinal(0)] [RED("("groupsBlendTime")] 		public CFloat GroupsBlendTime { get; set;}

		[Ordinal(0)] [RED("("quickTurnBlendTime")] 		public CFloat QuickTurnBlendTime { get; set;}

		[Ordinal(0)] [RED("("fasterQuickTurnBlendTime")] 		public CFloat FasterQuickTurnBlendTime { get; set;}

		[Ordinal(0)] [RED("("angleThresholdForQuickTurn")] 		public CFloat AngleThresholdForQuickTurn { get; set;}

		[Ordinal(0)] [RED("("reverseSyncOnQuickTurnFwdBwd")] 		public CBool ReverseSyncOnQuickTurnFwdBwd { get; set;}

		[Ordinal(0)] [RED("("reverseSyncOnQuickTurnLeftRight")] 		public CBool ReverseSyncOnQuickTurnLeftRight { get; set;}

		[Ordinal(0)] [RED("("syncBlendingOffsetPTLOnQuickTurn")] 		public CFloat SyncBlendingOffsetPTLOnQuickTurn { get; set;}

		[Ordinal(0)] [RED("("startPTLRightFootInFront")] 		public CFloat StartPTLRightFootInFront { get; set;}

		[Ordinal(0)] [RED("("startPTLLeftFootInFront")] 		public CFloat StartPTLLeftFootInFront { get; set;}

		[Ordinal(0)] [RED("("alwaysStartAtZero")] 		public CBool AlwaysStartAtZero { get; set;}

		[Ordinal(0)] [RED("("useSimpleBlendForMovementDelta")] 		public CBool UseSimpleBlendForMovementDelta { get; set;}

		[Ordinal(0)] [RED("("useDefinedVariablesAsRequestedInput")] 		public CBool UseDefinedVariablesAsRequestedInput { get; set;}

		[Ordinal(0)] [RED("("requestedMovementDirectionVariableName")] 		public CName RequestedMovementDirectionVariableName { get; set;}

		[Ordinal(0)] [RED("("requestedFacingDirectionVariableName")] 		public CName RequestedFacingDirectionVariableName { get; set;}

		[Ordinal(0)] [RED("("useDefinedInternalVariablesAsInitialInput")] 		public CBool UseDefinedInternalVariablesAsInitialInput { get; set;}

		[Ordinal(0)] [RED("("movementDirectionInternalVariableName")] 		public CName MovementDirectionInternalVariableName { get; set;}

		[Ordinal(0)] [RED("("groupDirInternalVariableName")] 		public CName GroupDirInternalVariableName { get; set;}

		[Ordinal(0)] [RED("("loopCount")] 		public CInt32 LoopCount { get; set;}

		[Ordinal(0)] [RED("("syncGroupOffsetPTL")] 		public CFloat SyncGroupOffsetPTL { get; set;}

		[Ordinal(0)] [RED("("Right foot bone name")] 		public CName Right_foot_bone_name { get; set;}

		[Ordinal(0)] [RED("("Left foot bone name")] 		public CName Left_foot_bone_name { get; set;}

		[Ordinal(0)] [RED("("groupDir")] 		public CFloat GroupDir { get; set;}

		[Ordinal(0)] [RED("("sideAngleRange")] 		public CFloat SideAngleRange { get; set;}

		[Ordinal(0)] [RED("("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(0)] [RED("("allInputsValid")] 		public CBool AllInputsValid { get; set;}

		[Ordinal(0)] [RED("("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[Ordinal(0)] [RED("("cachedRequestedMovementDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedMovementDirectionWSValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedRequestedFacingDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedFacingDirectionWSValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedInitialMovementDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedInitialMovementDirectionWSValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedInitialGroupDirMSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedInitialGroupDirMSValueNode { get; set;}

		public CBehaviorGraphDirectionalMovementNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphDirectionalMovementNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}