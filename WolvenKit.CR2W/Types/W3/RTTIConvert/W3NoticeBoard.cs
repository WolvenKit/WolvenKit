using System.IO;
using System.Runtime.Serialization;
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

		[RED("noticeboardDisabled")] 		public CBool NoticeboardDisabled { get; set;}

		[RED("activeErrands", 2,0)] 		public CArray<ErrandDetailsList> ActiveErrands { get; set;}

		[RED("updatingInteraction")] 		public CBool UpdatingInteraction { get; set;}

		[RED("errandPositionName")] 		public CString ErrandPositionName { get; set;}

		[RED("MAX_DISPLAYED_ERRANDS")] 		public CInt32 MAX_DISPLAYED_ERRANDS { get; set;}

		[RED("lastTimeInteracted")] 		public GameTime LastTimeInteracted { get; set;}

		[RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[RED("hack_updateTriesLeft")] 		public CInt32 Hack_updateTriesLeft { get; set;}

		[RED("hack_isTryingUpdate")] 		public CBool Hack_isTryingUpdate { get; set;}

		[RED("hack_started")] 		public CBool Hack_started { get; set;}

		[RED("hack_fromAreaEnter")] 		public CBool Hack_fromAreaEnter { get; set;}

		public W3NoticeBoard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3NoticeBoard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}