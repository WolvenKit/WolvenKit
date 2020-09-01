using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGesturesManager : IBehTreeTask
	{
		[Ordinal(0)] [RED("("disableGestures")] 		public CBool DisableGestures { get; set;}

		[Ordinal(0)] [RED("("removePlayedAnimationFromPool")] 		public CBool RemovePlayedAnimationFromPool { get; set;}

		[Ordinal(0)] [RED("("gossipGesturesOnly")] 		public CBool GossipGesturesOnly { get; set;}

		[Ordinal(0)] [RED("("dontActivateGestureWhenNotTalking")] 		public CBool DontActivateGestureWhenNotTalking { get; set;}

		[Ordinal(0)] [RED("("onlyOneActorGesticulatingAtATime")] 		public CBool OnlyOneActorGesticulatingAtATime { get; set;}

		[Ordinal(0)] [RED("("stopGestureOnDeactivate")] 		public CBool StopGestureOnDeactivate { get; set;}

		[Ordinal(0)] [RED("("dontOverrideRightHand")] 		public CBool DontOverrideRightHand { get; set;}

		[Ordinal(0)] [RED("("dontOverrideLeftHand")] 		public CBool DontOverrideLeftHand { get; set;}

		[Ordinal(0)] [RED("("cooldownBetweenGesture")] 		public CFloat CooldownBetweenGesture { get; set;}

		[Ordinal(0)] [RED("("chanceToPlayGesture")] 		public CFloat ChanceToPlayGesture { get; set;}

		[Ordinal(0)] [RED("("m_animListLeftHand", 2,0)] 		public CArray<CName> M_animListLeftHand { get; set;}

		[Ordinal(0)] [RED("("m_animListRightHand", 2,0)] 		public CArray<CName> M_animListRightHand { get; set;}

		[Ordinal(0)] [RED("("m_animListBothHands", 2,0)] 		public CArray<CName> M_animListBothHands { get; set;}

		[Ordinal(0)] [RED("("m_animList", 2,0)] 		public CArray<CName> M_animList { get; set;}

		[Ordinal(0)] [RED("("animListLeftHand", 2,0)] 		public CArray<CName> AnimListLeftHand { get; set;}

		[Ordinal(0)] [RED("("animListRightHand", 2,0)] 		public CArray<CName> AnimListRightHand { get; set;}

		[Ordinal(0)] [RED("("animListBothHands", 2,0)] 		public CArray<CName> AnimListBothHands { get; set;}

		[Ordinal(0)] [RED("("animList", 2,0)] 		public CArray<CName> AnimList { get; set;}

		[Ordinal(0)] [RED("("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(0)] [RED("("reactionEventTimeStamp")] 		public CFloat ReactionEventTimeStamp { get; set;}

		[Ordinal(0)] [RED("("itemInLeftHand")] 		public CBool ItemInLeftHand { get; set;}

		[Ordinal(0)] [RED("("itemInRightHand")] 		public CBool ItemInRightHand { get; set;}

		public CBTTaskGesturesManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGesturesManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}