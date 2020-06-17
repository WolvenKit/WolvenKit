using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFollowLeaderTree : IAIIdleFormationTree
	{
		[RED("leaderName")] 		public CName LeaderName { get; set;}

		[RED("disableGestures")] 		public CBool DisableGestures { get; set;}

		[RED("removePlayedAnimationFromPool")] 		public CBool RemovePlayedAnimationFromPool { get; set;}

		[RED("gossipGesturesOnly")] 		public CBool GossipGesturesOnly { get; set;}

		[RED("cooldownBetweenGesture")] 		public CFloat CooldownBetweenGesture { get; set;}

		[RED("chanceToPlayGesture")] 		public CFloat ChanceToPlayGesture { get; set;}

		[RED("dontActivateGestureWhenNotTalking")] 		public CBool DontActivateGestureWhenNotTalking { get; set;}

		[RED("onlyOneActorGesticulatingAtATime")] 		public CBool OnlyOneActorGesticulatingAtATime { get; set;}

		[RED("stopGestureOnDeactivate")] 		public CBool StopGestureOnDeactivate { get; set;}

		[RED("dontOverrideRightHand")] 		public CBool DontOverrideRightHand { get; set;}

		[RED("dontOverrideLeftHand")] 		public CBool DontOverrideLeftHand { get; set;}

		public CAIFollowLeaderTree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIFollowLeaderTree(cr2w);

	}
}