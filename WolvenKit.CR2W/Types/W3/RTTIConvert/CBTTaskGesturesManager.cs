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
		[RED("disableGestures")] 		public CBool DisableGestures { get; set;}

		[RED("removePlayedAnimationFromPool")] 		public CBool RemovePlayedAnimationFromPool { get; set;}

		[RED("gossipGesturesOnly")] 		public CBool GossipGesturesOnly { get; set;}

		[RED("dontActivateGestureWhenNotTalking")] 		public CBool DontActivateGestureWhenNotTalking { get; set;}

		[RED("onlyOneActorGesticulatingAtATime")] 		public CBool OnlyOneActorGesticulatingAtATime { get; set;}

		[RED("stopGestureOnDeactivate")] 		public CBool StopGestureOnDeactivate { get; set;}

		[RED("dontOverrideRightHand")] 		public CBool DontOverrideRightHand { get; set;}

		[RED("dontOverrideLeftHand")] 		public CBool DontOverrideLeftHand { get; set;}

		[RED("cooldownBetweenGesture")] 		public CFloat CooldownBetweenGesture { get; set;}

		[RED("chanceToPlayGesture")] 		public CFloat ChanceToPlayGesture { get; set;}

		[RED("m_animListLeftHand", 2,0)] 		public CArray<CName> M_animListLeftHand { get; set;}

		[RED("m_animListRightHand", 2,0)] 		public CArray<CName> M_animListRightHand { get; set;}

		[RED("m_animListBothHands", 2,0)] 		public CArray<CName> M_animListBothHands { get; set;}

		[RED("m_animList", 2,0)] 		public CArray<CName> M_animList { get; set;}

		[RED("animListLeftHand", 2,0)] 		public CArray<CName> AnimListLeftHand { get; set;}

		[RED("animListRightHand", 2,0)] 		public CArray<CName> AnimListRightHand { get; set;}

		[RED("animListBothHands", 2,0)] 		public CArray<CName> AnimListBothHands { get; set;}

		[RED("animList", 2,0)] 		public CArray<CName> AnimList { get; set;}

		[RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[RED("reactionEventTimeStamp")] 		public CFloat ReactionEventTimeStamp { get; set;}

		[RED("itemInLeftHand")] 		public CBool ItemInLeftHand { get; set;}

		[RED("itemInRightHand")] 		public CBool ItemInRightHand { get; set;}

		public CBTTaskGesturesManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGesturesManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}