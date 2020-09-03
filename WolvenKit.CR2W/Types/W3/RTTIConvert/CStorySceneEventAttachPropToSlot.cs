using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventAttachPropToSlot : CStorySceneEvent
	{
		[Ordinal(1)] [RED("propId")] 		public CName PropId { get; set;}

		[Ordinal(2)] [RED("activate")] 		public CBool Activate { get; set;}

		[Ordinal(3)] [RED("actorName")] 		public CName ActorName { get; set;}

		[Ordinal(4)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(5)] [RED("snapAtStart")] 		public CBool SnapAtStart { get; set;}

		[Ordinal(6)] [RED("showHide")] 		public CBool ShowHide { get; set;}

		[Ordinal(7)] [RED("offset")] 		public EngineTransform Offset { get; set;}

		public CStorySceneEventAttachPropToSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventAttachPropToSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}