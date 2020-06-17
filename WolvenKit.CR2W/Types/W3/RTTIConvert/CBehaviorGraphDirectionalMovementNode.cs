using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphDirectionalMovementNode : CBehaviorGraphNode
	{
		[RED("groupCount")] 		public CInt32 GroupCount { get; set;}

		[RED("animsPerGroup")] 		public CInt32 AnimsPerGroup { get; set;}

		[RED("firstGroupDirOffset")] 		public CFloat FirstGroupDirOffset { get; set;}

		[RED("extraOverlapAngle")] 		public CFloat ExtraOverlapAngle { get; set;}

		[RED("keepInCurrentGroupAngle")] 		public CFloat KeepInCurrentGroupAngle { get; set;}

		[RED("findGroupDirOffset")] 		public CFloat FindGroupDirOffset { get; set;}

		[RED("singleAnimOnly")] 		public CBool SingleAnimOnly { get; set;}

		[RED("doNotSwitchAnim")] 		public CBool DoNotSwitchAnim { get; set;}

		[RED("movementDirBlendTime")] 		public CFloat MovementDirBlendTime { get; set;}

		[RED("movementDirMaxSpeedChange")] 		public CFloat MovementDirMaxSpeedChange { get; set;}

		[RED("groupsBlendTime")] 		public CFloat GroupsBlendTime { get; set;}

		[RED("quickTurnBlendTime")] 		public CFloat QuickTurnBlendTime { get; set;}

		[RED("fasterQuickTurnBlendTime")] 		public CFloat FasterQuickTurnBlendTime { get; set;}

		[RED("angleThresholdForQuickTurn")] 		public CFloat AngleThresholdForQuickTurn { get; set;}

		[RED("reverseSyncOnQuickTurnFwdBwd")] 		public CBool ReverseSyncOnQuickTurnFwdBwd { get; set;}

		[RED("reverseSyncOnQuickTurnLeftRight")] 		public CBool ReverseSyncOnQuickTurnLeftRight { get; set;}

		[RED("syncBlendingOffsetPTLOnQuickTurn")] 		public CFloat SyncBlendingOffsetPTLOnQuickTurn { get; set;}

		[RED("startPTLRightFootInFront")] 		public CFloat StartPTLRightFootInFront { get; set;}

		[RED("startPTLLeftFootInFront")] 		public CFloat StartPTLLeftFootInFront { get; set;}

		[RED("alwaysStartAtZero")] 		public CBool AlwaysStartAtZero { get; set;}

		[RED("useSimpleBlendForMovementDelta")] 		public CBool UseSimpleBlendForMovementDelta { get; set;}

		[RED("useDefinedVariablesAsRequestedInput")] 		public CBool UseDefinedVariablesAsRequestedInput { get; set;}

		[RED("requestedMovementDirectionVariableName")] 		public CName RequestedMovementDirectionVariableName { get; set;}

		[RED("requestedFacingDirectionVariableName")] 		public CName RequestedFacingDirectionVariableName { get; set;}

		[RED("useDefinedInternalVariablesAsInitialInput")] 		public CBool UseDefinedInternalVariablesAsInitialInput { get; set;}

		[RED("movementDirectionInternalVariableName")] 		public CName MovementDirectionInternalVariableName { get; set;}

		[RED("groupDirInternalVariableName")] 		public CName GroupDirInternalVariableName { get; set;}

		[RED("loopCount")] 		public CInt32 LoopCount { get; set;}

		[RED("syncGroupOffsetPTL")] 		public CFloat SyncGroupOffsetPTL { get; set;}

		[RED("Right foot bone name")] 		public CName Right_foot_bone_name { get; set;}

		[RED("Left foot bone name")] 		public CName Left_foot_bone_name { get; set;}

		[RED("groupDir")] 		public CFloat GroupDir { get; set;}

		[RED("sideAngleRange")] 		public CFloat SideAngleRange { get; set;}

		[RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[RED("allInputsValid")] 		public CBool AllInputsValid { get; set;}

		[RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[RED("cachedRequestedMovementDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedMovementDirectionWSValueNode { get; set;}

		[RED("cachedRequestedFacingDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedFacingDirectionWSValueNode { get; set;}

		[RED("cachedInitialMovementDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedInitialMovementDirectionWSValueNode { get; set;}

		[RED("cachedInitialGroupDirMSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedInitialGroupDirMSValueNode { get; set;}

		public CBehaviorGraphDirectionalMovementNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphDirectionalMovementNode(cr2w);

	}
}