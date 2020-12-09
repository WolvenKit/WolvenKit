using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(2)] [RED("loopPlayback")] 		public CBool LoopPlayback { get; set;}

		[Ordinal(3)] [RED("playbackSpeed")] 		public CFloat PlaybackSpeed { get; set;}

		[Ordinal(4)] [RED("applyMotion")] 		public CBool ApplyMotion { get; set;}

		[Ordinal(5)] [RED("extractMotionTranslation")] 		public CBool ExtractMotionTranslation { get; set;}

		[Ordinal(6)] [RED("extractMotionRotation")] 		public CBool ExtractMotionRotation { get; set;}

		[Ordinal(7)] [RED("fireLoopEvent")] 		public CBool FireLoopEvent { get; set;}

		[Ordinal(8)] [RED("loopEventName")] 		public CName LoopEventName { get; set;}

		[Ordinal(9)] [RED("useFovTrack")] 		public CBool UseFovTrack { get; set;}

		[Ordinal(10)] [RED("useDofTrack")] 		public CBool UseDofTrack { get; set;}

		[Ordinal(11)] [RED("gatherEvents")] 		public CBool GatherEvents { get; set;}

		[Ordinal(12)] [RED("autoFireEffects")] 		public CBool AutoFireEffects { get; set;}

		[Ordinal(13)] [RED("gatherSyncTokens")] 		public CBool GatherSyncTokens { get; set;}

		[Ordinal(14)] [RED("cachedForceTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedForceTimeNode { get; set;}

		[Ordinal(15)] [RED("cachedSpeedTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedTimeNode { get; set;}

		[Ordinal(16)] [RED("cachedForcePropNode")] 		public CPtr<CBehaviorGraphValueNode> CachedForcePropNode { get; set;}

		public CBehaviorGraphAnimationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}