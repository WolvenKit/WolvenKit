using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationNode : CBehaviorGraphValueNode
	{
		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("loopPlayback")] 		public CBool LoopPlayback { get; set;}

		[RED("playbackSpeed")] 		public CFloat PlaybackSpeed { get; set;}

		[RED("applyMotion")] 		public CBool ApplyMotion { get; set;}

		[RED("extractMotionTranslation")] 		public CBool ExtractMotionTranslation { get; set;}

		[RED("extractMotionRotation")] 		public CBool ExtractMotionRotation { get; set;}

		[RED("fireLoopEvent")] 		public CBool FireLoopEvent { get; set;}

		[RED("loopEventName")] 		public CName LoopEventName { get; set;}

		[RED("useFovTrack")] 		public CBool UseFovTrack { get; set;}

		[RED("useDofTrack")] 		public CBool UseDofTrack { get; set;}

		[RED("gatherEvents")] 		public CBool GatherEvents { get; set;}

		[RED("autoFireEffects")] 		public CBool AutoFireEffects { get; set;}

		[RED("gatherSyncTokens")] 		public CBool GatherSyncTokens { get; set;}

		[RED("cachedForceTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedForceTimeNode { get; set;}

		[RED("cachedSpeedTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedTimeNode { get; set;}

		[RED("cachedForcePropNode")] 		public CPtr<CBehaviorGraphValueNode> CachedForcePropNode { get; set;}

		public CBehaviorGraphAnimationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}