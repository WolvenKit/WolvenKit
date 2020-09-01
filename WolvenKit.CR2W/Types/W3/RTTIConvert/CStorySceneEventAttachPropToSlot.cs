using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventAttachPropToSlot : CStorySceneEvent
	{
		[Ordinal(0)] [RED("("propId")] 		public CName PropId { get; set;}

		[Ordinal(0)] [RED("("activate")] 		public CBool Activate { get; set;}

		[Ordinal(0)] [RED("("actorName")] 		public CName ActorName { get; set;}

		[Ordinal(0)] [RED("("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(0)] [RED("("snapAtStart")] 		public CBool SnapAtStart { get; set;}

		[Ordinal(0)] [RED("("showHide")] 		public CBool ShowHide { get; set;}

		[Ordinal(0)] [RED("("offset")] 		public EngineTransform Offset { get; set;}

		public CStorySceneEventAttachPropToSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventAttachPropToSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}