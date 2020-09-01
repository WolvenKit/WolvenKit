using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationNode : CBehaviorGraphValueNode
	{
		[Ordinal(0)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(0)] [RED("loopPlayback")] 		public CBool LoopPlayback { get; set;}

		[Ordinal(0)] [RED("playbackSpeed")] 		public CFloat PlaybackSpeed { get; set;}

		[Ordinal(0)] [RED("applyMotion")] 		public CBool ApplyMotion { get; set;}

		[Ordinal(0)] [RED("extractMotionTranslation")] 		public CBool ExtractMotionTranslation { get; set;}

		[Ordinal(0)] [RED("extractMotionRotation")] 		public CBool ExtractMotionRotation { get; set;}

		[Ordinal(0)] [RED("fireLoopEvent")] 		public CBool FireLoopEvent { get; set;}

		[Ordinal(0)] [RED("loopEventName")] 		public CName LoopEventName { get; set;}

		[Ordinal(0)] [RED("useFovTrack")] 		public CBool UseFovTrack { get; set;}

		[Ordinal(0)] [RED("useDofTrack")] 		public CBool UseDofTrack { get; set;}

		[Ordinal(0)] [RED("gatherEvents")] 		public CBool GatherEvents { get; set;}

		[Ordinal(0)] [RED("autoFireEffects")] 		public CBool AutoFireEffects { get; set;}

		[Ordinal(0)] [RED("gatherSyncTokens")] 		public CBool GatherSyncTokens { get; set;}

		[Ordinal(0)] [RED("cachedForceTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedForceTimeNode { get; set;}

		[Ordinal(0)] [RED("cachedSpeedTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedTimeNode { get; set;}

		[Ordinal(0)] [RED("cachedForcePropNode")] 		public CPtr<CBehaviorGraphValueNode> CachedForcePropNode { get; set;}

		public CBehaviorGraphAnimationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}