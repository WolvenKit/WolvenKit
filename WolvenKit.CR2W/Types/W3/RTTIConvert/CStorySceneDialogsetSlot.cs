using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneDialogsetSlot : CObject
	{
		[Ordinal(1)] [RED("slotNumber")] 		public CUInt32 SlotNumber { get; set;}

		[Ordinal(2)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(3)] [RED("slotPlacement")] 		public EngineTransform SlotPlacement { get; set;}

		[Ordinal(4)] [RED("actorName")] 		public CName ActorName { get; set;}

		[Ordinal(5)] [RED("actorVisibility")] 		public CBool ActorVisibility { get; set;}

		[Ordinal(6)] [RED("actorStatus")] 		public CName ActorStatus { get; set;}

		[Ordinal(7)] [RED("actorEmotionalState")] 		public CName ActorEmotionalState { get; set;}

		[Ordinal(8)] [RED("actorPoseName")] 		public CName ActorPoseName { get; set;}

		[Ordinal(9)] [RED("actorMimicsEmotionalState")] 		public CName ActorMimicsEmotionalState { get; set;}

		[Ordinal(10)] [RED("actorMimicsLayer_Eyes")] 		public CName ActorMimicsLayer_Eyes { get; set;}

		[Ordinal(11)] [RED("actorMimicsLayer_Pose")] 		public CName ActorMimicsLayer_Pose { get; set;}

		[Ordinal(12)] [RED("actorMimicsLayer_Animation")] 		public CName ActorMimicsLayer_Animation { get; set;}

		[Ordinal(13)] [RED("actorMimicsLayer_Pose_Weight")] 		public CFloat ActorMimicsLayer_Pose_Weight { get; set;}

		[Ordinal(14)] [RED("forceBodyIdleAnimation")] 		public CName ForceBodyIdleAnimation { get; set;}

		[Ordinal(15)] [RED("forceBodyIdleAnimationWeight")] 		public CFloat ForceBodyIdleAnimationWeight { get; set;}

		[Ordinal(16)] [RED("actorState")] 		public CName ActorState { get; set;}

		[Ordinal(17)] [RED("ID")] 		public CGUID ID { get; set;}

		[Ordinal(18)] [RED("setupAction", 2,0)] 		public CArray<CPtr<CStorySceneAction>> SetupAction { get; set;}

		public CStorySceneDialogsetSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneDialogsetSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}