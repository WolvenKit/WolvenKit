using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGesturesManagerDef : IBehTreeTaskDefinition
	{
		[RED("disableGestures")] 		public CBehTreeValBool DisableGestures { get; set;}

		[RED("removePlayedAnimationFromPool")] 		public CBehTreeValBool RemovePlayedAnimationFromPool { get; set;}

		[RED("gossipGesturesOnly")] 		public CBehTreeValBool GossipGesturesOnly { get; set;}

		[RED("cooldownBetweenGesture")] 		public CBehTreeValFloat CooldownBetweenGesture { get; set;}

		[RED("chanceToPlayGesture")] 		public CBehTreeValFloat ChanceToPlayGesture { get; set;}

		[RED("dontActivateGestureWhenNotTalking")] 		public CBehTreeValBool DontActivateGestureWhenNotTalking { get; set;}

		[RED("onlyOneActorGesticulatingAtATime")] 		public CBehTreeValBool OnlyOneActorGesticulatingAtATime { get; set;}

		[RED("stopGestureOnDeactivate")] 		public CBehTreeValBool StopGestureOnDeactivate { get; set;}

		[RED("dontOverrideRightHand")] 		public CBehTreeValBool DontOverrideRightHand { get; set;}

		[RED("dontOverrideLeftHand")] 		public CBehTreeValBool DontOverrideLeftHand { get; set;}

		public CBTTaskGesturesManagerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGesturesManagerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}