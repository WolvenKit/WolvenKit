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
		[RED("START_SWIMMING_WATER_LEVEL")] 		public CFloat START_SWIMMING_WATER_LEVEL { get; set;}

		[RED("LEAVE_STATE_WATER_LEVEL")] 		public CFloat LEAVE_STATE_WATER_LEVEL { get; set;}

		[RED("LEAVE_STATE_SUBMERGE_DEPTH")] 		public CFloat LEAVE_STATE_SUBMERGE_DEPTH { get; set;}

		[RED("WALK_DEEP_WATER_LEVEL")] 		public CFloat WALK_DEEP_WATER_LEVEL { get; set;}

		[RED("MIN_WATER_LEVEL_FOR_DIVING")] 		public CFloat MIN_WATER_LEVEL_FOR_DIVING { get; set;}

		[RED("ENTER_DIVING_WATER_LEVEL")] 		public CFloat ENTER_DIVING_WATER_LEVEL { get; set;}

		[RED("EXIT_DIVING_WATER_LEVEL")] 		public CFloat EXIT_DIVING_WATER_LEVEL { get; set;}

		[RED("MINIMAL_SUBMERGE_DEPTH")] 		public CFloat MINIMAL_SUBMERGE_DEPTH { get; set;}

		[RED("jumpToWaterAnimDist")] 		public CFloat JumpToWaterAnimDist { get; set;}

		[RED("swimToIdleAnimDist")] 		public CFloat SwimToIdleAnimDist { get; set;}

		[RED("splashEntityTemplate")] 		public CHandle<CEntityTemplate> SplashEntityTemplate { get; set;}

		[RED("walkDeep")] 		public CBool WalkDeep { get; set;}

		[RED("swimming")] 		public CBool Swimming { get; set;}

		[RED("diving")] 		public CBool Diving { get; set;}

		[RED("divingStarting")] 		public CBool DivingStarting { get; set;}

		[RED("swimStart")] 		public CBool SwimStart { get; set;}

		[RED("unlimitedDiving")] 		public CBool UnlimitedDiving { get; set;}

		[RED("swimStagger")] 		public CBool SwimStagger { get; set;}

		[RED("minSubmergeDepthReached")] 		public CBool MinSubmergeDepthReached { get; set;}

		[RED("inDivingState")] 		public CBool InDivingState { get; set;}

		[RED("divingEnd")] 		public CBool DivingEnd { get; set;}

		[RED("blockPopState")] 		public CBool BlockPopState { get; set;}

		[RED("usePredicitonDepth")] 		public CBool UsePredicitonDepth { get; set;}

		[RED("divingEffectPlaying")] 		public CBool DivingEffectPlaying { get; set;}

		[RED("jumpToWaterInProgress")] 		public CBool JumpToWaterInProgress { get; set;}

		[RED("startSwimPos")] 		public Vector StartSwimPos { get; set;}

		[RED("isCiri")] 		public CBool IsCiri { get; set;}

		[RED("currentWaterDepth")] 		public CFloat CurrentWaterDepth { get; set;}

		[RED("cachedVerCameraTimeout")] 		public CFloat CachedVerCameraTimeout { get; set;}

		[RED("defaultEmergeSpeed")] 		public CFloat DefaultEmergeSpeed { get; set;}

		[RED("windPower")] 		public CFloat WindPower { get; set;}

		[RED("predictedWaterDepth")] 		public CFloat PredictedWaterDepth { get; set;}

		[RED("blockDiveDown")] 		public CBool BlockDiveDown { get; set;}

		[RED("runJumpInProgress")] 		public CBool RunJumpInProgress { get; set;}

		[RED("cameraIsUnderwater")] 		public CBool CameraIsUnderwater { get; set;}

		[RED("cameraPitch")] 		public CFloat CameraPitch { get; set;}

		public CR4PlayerStateSwimming(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateSwimming(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}