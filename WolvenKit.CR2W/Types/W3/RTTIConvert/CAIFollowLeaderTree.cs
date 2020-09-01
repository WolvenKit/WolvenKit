using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFollowLeaderTree : IAIIdleFormationTree
	{
		[Ordinal(0)] [RED("leaderName")] 		public CName LeaderName { get; set;}

		[Ordinal(0)] [RED("disableGestures")] 		public CBool DisableGestures { get; set;}

		[Ordinal(0)] [RED("removePlayedAnimationFromPool")] 		public CBool RemovePlayedAnimationFromPool { get; set;}

		[Ordinal(0)] [RED("gossipGesturesOnly")] 		public CBool GossipGesturesOnly { get; set;}

		[Ordinal(0)] [RED("cooldownBetweenGesture")] 		public CFloat CooldownBetweenGesture { get; set;}

		[Ordinal(0)] [RED("chanceToPlayGesture")] 		public CFloat ChanceToPlayGesture { get; set;}

		[Ordinal(0)] [RED("dontActivateGestureWhenNotTalking")] 		public CBool DontActivateGestureWhenNotTalking { get; set;}

		[Ordinal(0)] [RED("onlyOneActorGesticulatingAtATime")] 		public CBool OnlyOneActorGesticulatingAtATime { get; set;}

		[Ordinal(0)] [RED("stopGestureOnDeactivate")] 		public CBool StopGestureOnDeactivate { get; set;}

		[Ordinal(0)] [RED("dontOverrideRightHand")] 		public CBool DontOverrideRightHand { get; set;}

		[Ordinal(0)] [RED("dontOverrideLeftHand")] 		public CBool DontOverrideLeftHand { get; set;}

		public CAIFollowLeaderTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFollowLeaderTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}