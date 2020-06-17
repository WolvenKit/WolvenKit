using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3NoticeBoard : CR4MapPinEntity
	{
		[RED("visited")] 		public CBool Visited { get; set;}

		[RED("addedNotes", 2,0)] 		public CArray<ErrandDetailsList> AddedNotes { get; set;}

		[RED("fluffNotices", 2,0)] 		public CArray<CString> FluffNotices { get; set;}

		[RED("entitiesToBeShown", 2,0)] 		public CArray<CName> EntitiesToBeShown { get; set;}

		[RED("questEntitiesToBeShown", 2,0)] 		public CArray<CName> QuestEntitiesToBeShown { get; set;}

		[RED("questNonActorEntitiesToBeShown", 2,0)] 		public CArray<CName> QuestNonActorEntitiesToBeShown { get; set;}

		[RED("InteractionSpawnDelayTime")] 		public CFloat InteractionSpawnDelayTime { get; set;}

		[RED("backgroundOverride")] 		public CString BackgroundOverride { get; set;}

		[RED("factAddedOnDiscovery")] 		public CName FactAddedOnDiscovery { get; set;}

		public W3NoticeBoard(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3NoticeBoard(cr2w);

	}
}