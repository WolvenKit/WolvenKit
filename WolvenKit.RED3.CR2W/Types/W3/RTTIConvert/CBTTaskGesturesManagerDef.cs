using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGesturesManagerDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("disableGestures")] 		public CBehTreeValBool DisableGestures { get; set;}

		[Ordinal(2)] [RED("removePlayedAnimationFromPool")] 		public CBehTreeValBool RemovePlayedAnimationFromPool { get; set;}

		[Ordinal(3)] [RED("gossipGesturesOnly")] 		public CBehTreeValBool GossipGesturesOnly { get; set;}

		[Ordinal(4)] [RED("cooldownBetweenGesture")] 		public CBehTreeValFloat CooldownBetweenGesture { get; set;}

		[Ordinal(5)] [RED("chanceToPlayGesture")] 		public CBehTreeValFloat ChanceToPlayGesture { get; set;}

		[Ordinal(6)] [RED("dontActivateGestureWhenNotTalking")] 		public CBehTreeValBool DontActivateGestureWhenNotTalking { get; set;}

		[Ordinal(7)] [RED("onlyOneActorGesticulatingAtATime")] 		public CBehTreeValBool OnlyOneActorGesticulatingAtATime { get; set;}

		[Ordinal(8)] [RED("stopGestureOnDeactivate")] 		public CBehTreeValBool StopGestureOnDeactivate { get; set;}

		[Ordinal(9)] [RED("dontOverrideRightHand")] 		public CBehTreeValBool DontOverrideRightHand { get; set;}

		[Ordinal(10)] [RED("dontOverrideLeftHand")] 		public CBehTreeValBool DontOverrideLeftHand { get; set;}

		public CBTTaskGesturesManagerDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}