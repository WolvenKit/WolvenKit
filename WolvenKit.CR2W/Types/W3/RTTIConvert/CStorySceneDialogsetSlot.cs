using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneDialogsetSlot : CObject
	{
		[Ordinal(0)] [RED("("slotNumber")] 		public CUInt32 SlotNumber { get; set;}

		[Ordinal(0)] [RED("("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(0)] [RED("("slotPlacement")] 		public EngineTransform SlotPlacement { get; set;}

		[Ordinal(0)] [RED("("actorName")] 		public CName ActorName { get; set;}

		[Ordinal(0)] [RED("("actorVisibility")] 		public CBool ActorVisibility { get; set;}

		[Ordinal(0)] [RED("("actorStatus")] 		public CName ActorStatus { get; set;}

		[Ordinal(0)] [RED("("actorEmotionalState")] 		public CName ActorEmotionalState { get; set;}

		[Ordinal(0)] [RED("("actorPoseName")] 		public CName ActorPoseName { get; set;}

		[Ordinal(0)] [RED("("actorMimicsEmotionalState")] 		public CName ActorMimicsEmotionalState { get; set;}

		[Ordinal(0)] [RED("("actorMimicsLayer_Eyes")] 		public CName ActorMimicsLayer_Eyes { get; set;}

		[Ordinal(0)] [RED("("actorMimicsLayer_Pose")] 		public CName ActorMimicsLayer_Pose { get; set;}

		[Ordinal(0)] [RED("("actorMimicsLayer_Animation")] 		public CName ActorMimicsLayer_Animation { get; set;}

		[Ordinal(0)] [RED("("actorMimicsLayer_Pose_Weight")] 		public CFloat ActorMimicsLayer_Pose_Weight { get; set;}

		[Ordinal(0)] [RED("("forceBodyIdleAnimation")] 		public CName ForceBodyIdleAnimation { get; set;}

		[Ordinal(0)] [RED("("forceBodyIdleAnimationWeight")] 		public CFloat ForceBodyIdleAnimationWeight { get; set;}

		[Ordinal(0)] [RED("("actorState")] 		public CName ActorState { get; set;}

		[Ordinal(0)] [RED("("ID")] 		public CGUID ID { get; set;}

		[Ordinal(0)] [RED("("setupAction", 2,0)] 		public CArray<CPtr<CStorySceneAction>> SetupAction { get; set;}

		public CStorySceneDialogsetSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneDialogsetSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}