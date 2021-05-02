using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateSwimming : CR4PlayerStateExtendedMovable
	{
		[Ordinal(1)] [RED("START_SWIMMING_WATER_LEVEL")] 		public CFloat START_SWIMMING_WATER_LEVEL { get; set;}

		[Ordinal(2)] [RED("LEAVE_STATE_WATER_LEVEL")] 		public CFloat LEAVE_STATE_WATER_LEVEL { get; set;}

		[Ordinal(3)] [RED("LEAVE_STATE_SUBMERGE_DEPTH")] 		public CFloat LEAVE_STATE_SUBMERGE_DEPTH { get; set;}

		[Ordinal(4)] [RED("WALK_DEEP_WATER_LEVEL")] 		public CFloat WALK_DEEP_WATER_LEVEL { get; set;}

		[Ordinal(5)] [RED("MIN_WATER_LEVEL_FOR_DIVING")] 		public CFloat MIN_WATER_LEVEL_FOR_DIVING { get; set;}

		[Ordinal(6)] [RED("ENTER_DIVING_WATER_LEVEL")] 		public CFloat ENTER_DIVING_WATER_LEVEL { get; set;}

		[Ordinal(7)] [RED("EXIT_DIVING_WATER_LEVEL")] 		public CFloat EXIT_DIVING_WATER_LEVEL { get; set;}

		[Ordinal(8)] [RED("MINIMAL_SUBMERGE_DEPTH")] 		public CFloat MINIMAL_SUBMERGE_DEPTH { get; set;}

		[Ordinal(9)] [RED("jumpToWaterAnimDist")] 		public CFloat JumpToWaterAnimDist { get; set;}

		[Ordinal(10)] [RED("swimToIdleAnimDist")] 		public CFloat SwimToIdleAnimDist { get; set;}

		[Ordinal(11)] [RED("splashEntityTemplate")] 		public CHandle<CEntityTemplate> SplashEntityTemplate { get; set;}

		[Ordinal(12)] [RED("walkDeep")] 		public CBool WalkDeep { get; set;}

		[Ordinal(13)] [RED("swimming")] 		public CBool Swimming { get; set;}

		[Ordinal(14)] [RED("diving")] 		public CBool Diving { get; set;}

		[Ordinal(15)] [RED("divingStarting")] 		public CBool DivingStarting { get; set;}

		[Ordinal(16)] [RED("swimStart")] 		public CBool SwimStart { get; set;}

		[Ordinal(17)] [RED("unlimitedDiving")] 		public CBool UnlimitedDiving { get; set;}

		[Ordinal(18)] [RED("swimStagger")] 		public CBool SwimStagger { get; set;}

		[Ordinal(19)] [RED("minSubmergeDepthReached")] 		public CBool MinSubmergeDepthReached { get; set;}

		[Ordinal(20)] [RED("inDivingState")] 		public CBool InDivingState { get; set;}

		[Ordinal(21)] [RED("divingEnd")] 		public CBool DivingEnd { get; set;}

		[Ordinal(22)] [RED("blockPopState")] 		public CBool BlockPopState { get; set;}

		[Ordinal(23)] [RED("usePredicitonDepth")] 		public CBool UsePredicitonDepth { get; set;}

		[Ordinal(24)] [RED("divingEffectPlaying")] 		public CBool DivingEffectPlaying { get; set;}

		[Ordinal(25)] [RED("jumpToWaterInProgress")] 		public CBool JumpToWaterInProgress { get; set;}

		[Ordinal(26)] [RED("startSwimPos")] 		public Vector StartSwimPos { get; set;}

		[Ordinal(27)] [RED("isCiri")] 		public CBool IsCiri { get; set;}

		[Ordinal(28)] [RED("currentWaterDepth")] 		public CFloat CurrentWaterDepth { get; set;}

		[Ordinal(29)] [RED("cachedVerCameraTimeout")] 		public CFloat CachedVerCameraTimeout { get; set;}

		[Ordinal(30)] [RED("defaultEmergeSpeed")] 		public CFloat DefaultEmergeSpeed { get; set;}

		[Ordinal(31)] [RED("windPower")] 		public CFloat WindPower { get; set;}

		[Ordinal(32)] [RED("predictedWaterDepth")] 		public CFloat PredictedWaterDepth { get; set;}

		[Ordinal(33)] [RED("blockDiveDown")] 		public CBool BlockDiveDown { get; set;}

		[Ordinal(34)] [RED("runJumpInProgress")] 		public CBool RunJumpInProgress { get; set;}

		[Ordinal(35)] [RED("cameraIsUnderwater")] 		public CBool CameraIsUnderwater { get; set;}

		[Ordinal(36)] [RED("cameraPitch")] 		public CFloat CameraPitch { get; set;}

		public CR4PlayerStateSwimming(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateSwimming(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}