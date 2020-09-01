using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateSwimming : CR4PlayerStateExtendedMovable
	{
		[Ordinal(0)] [RED("START_SWIMMING_WATER_LEVEL")] 		public CFloat START_SWIMMING_WATER_LEVEL { get; set;}

		[Ordinal(0)] [RED("LEAVE_STATE_WATER_LEVEL")] 		public CFloat LEAVE_STATE_WATER_LEVEL { get; set;}

		[Ordinal(0)] [RED("LEAVE_STATE_SUBMERGE_DEPTH")] 		public CFloat LEAVE_STATE_SUBMERGE_DEPTH { get; set;}

		[Ordinal(0)] [RED("WALK_DEEP_WATER_LEVEL")] 		public CFloat WALK_DEEP_WATER_LEVEL { get; set;}

		[Ordinal(0)] [RED("MIN_WATER_LEVEL_FOR_DIVING")] 		public CFloat MIN_WATER_LEVEL_FOR_DIVING { get; set;}

		[Ordinal(0)] [RED("ENTER_DIVING_WATER_LEVEL")] 		public CFloat ENTER_DIVING_WATER_LEVEL { get; set;}

		[Ordinal(0)] [RED("EXIT_DIVING_WATER_LEVEL")] 		public CFloat EXIT_DIVING_WATER_LEVEL { get; set;}

		[Ordinal(0)] [RED("MINIMAL_SUBMERGE_DEPTH")] 		public CFloat MINIMAL_SUBMERGE_DEPTH { get; set;}

		[Ordinal(0)] [RED("jumpToWaterAnimDist")] 		public CFloat JumpToWaterAnimDist { get; set;}

		[Ordinal(0)] [RED("swimToIdleAnimDist")] 		public CFloat SwimToIdleAnimDist { get; set;}

		[Ordinal(0)] [RED("splashEntityTemplate")] 		public CHandle<CEntityTemplate> SplashEntityTemplate { get; set;}

		[Ordinal(0)] [RED("walkDeep")] 		public CBool WalkDeep { get; set;}

		[Ordinal(0)] [RED("swimming")] 		public CBool Swimming { get; set;}

		[Ordinal(0)] [RED("diving")] 		public CBool Diving { get; set;}

		[Ordinal(0)] [RED("divingStarting")] 		public CBool DivingStarting { get; set;}

		[Ordinal(0)] [RED("swimStart")] 		public CBool SwimStart { get; set;}

		[Ordinal(0)] [RED("unlimitedDiving")] 		public CBool UnlimitedDiving { get; set;}

		[Ordinal(0)] [RED("swimStagger")] 		public CBool SwimStagger { get; set;}

		[Ordinal(0)] [RED("minSubmergeDepthReached")] 		public CBool MinSubmergeDepthReached { get; set;}

		[Ordinal(0)] [RED("inDivingState")] 		public CBool InDivingState { get; set;}

		[Ordinal(0)] [RED("divingEnd")] 		public CBool DivingEnd { get; set;}

		[Ordinal(0)] [RED("blockPopState")] 		public CBool BlockPopState { get; set;}

		[Ordinal(0)] [RED("usePredicitonDepth")] 		public CBool UsePredicitonDepth { get; set;}

		[Ordinal(0)] [RED("divingEffectPlaying")] 		public CBool DivingEffectPlaying { get; set;}

		[Ordinal(0)] [RED("jumpToWaterInProgress")] 		public CBool JumpToWaterInProgress { get; set;}

		[Ordinal(0)] [RED("startSwimPos")] 		public Vector StartSwimPos { get; set;}

		[Ordinal(0)] [RED("isCiri")] 		public CBool IsCiri { get; set;}

		[Ordinal(0)] [RED("currentWaterDepth")] 		public CFloat CurrentWaterDepth { get; set;}

		[Ordinal(0)] [RED("cachedVerCameraTimeout")] 		public CFloat CachedVerCameraTimeout { get; set;}

		[Ordinal(0)] [RED("defaultEmergeSpeed")] 		public CFloat DefaultEmergeSpeed { get; set;}

		[Ordinal(0)] [RED("windPower")] 		public CFloat WindPower { get; set;}

		[Ordinal(0)] [RED("predictedWaterDepth")] 		public CFloat PredictedWaterDepth { get; set;}

		[Ordinal(0)] [RED("blockDiveDown")] 		public CBool BlockDiveDown { get; set;}

		[Ordinal(0)] [RED("runJumpInProgress")] 		public CBool RunJumpInProgress { get; set;}

		[Ordinal(0)] [RED("cameraIsUnderwater")] 		public CBool CameraIsUnderwater { get; set;}

		[Ordinal(0)] [RED("cameraPitch")] 		public CFloat CameraPitch { get; set;}

		public CR4PlayerStateSwimming(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateSwimming(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}