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
		[Ordinal(0)] [RED("("visited")] 		public CBool Visited { get; set;}

		[Ordinal(0)] [RED("("addedNotes", 2,0)] 		public CArray<ErrandDetailsList> AddedNotes { get; set;}

		[Ordinal(0)] [RED("("fluffNotices", 2,0)] 		public CArray<CString> FluffNotices { get; set;}

		[Ordinal(0)] [RED("("entitiesToBeShown", 2,0)] 		public CArray<CName> EntitiesToBeShown { get; set;}

		[Ordinal(0)] [RED("("questEntitiesToBeShown", 2,0)] 		public CArray<CName> QuestEntitiesToBeShown { get; set;}

		[Ordinal(0)] [RED("("questNonActorEntitiesToBeShown", 2,0)] 		public CArray<CName> QuestNonActorEntitiesToBeShown { get; set;}

		[Ordinal(0)] [RED("("InteractionSpawnDelayTime")] 		public CFloat InteractionSpawnDelayTime { get; set;}

		[Ordinal(0)] [RED("("backgroundOverride")] 		public CString BackgroundOverride { get; set;}

		[Ordinal(0)] [RED("("factAddedOnDiscovery")] 		public CName FactAddedOnDiscovery { get; set;}

		[Ordinal(0)] [RED("("noticeboardDisabled")] 		public CBool NoticeboardDisabled { get; set;}

		[Ordinal(0)] [RED("("activeErrands", 2,0)] 		public CArray<ErrandDetailsList> ActiveErrands { get; set;}

		[Ordinal(0)] [RED("("updatingInteraction")] 		public CBool UpdatingInteraction { get; set;}

		[Ordinal(0)] [RED("("errandPositionName")] 		public CString ErrandPositionName { get; set;}

		[Ordinal(0)] [RED("("MAX_DISPLAYED_ERRANDS")] 		public CInt32 MAX_DISPLAYED_ERRANDS { get; set;}

		[Ordinal(0)] [RED("("lastTimeInteracted")] 		public GameTime LastTimeInteracted { get; set;}

		[Ordinal(0)] [RED("("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(0)] [RED("("hack_updateTriesLeft")] 		public CInt32 Hack_updateTriesLeft { get; set;}

		[Ordinal(0)] [RED("("hack_isTryingUpdate")] 		public CBool Hack_isTryingUpdate { get; set;}

		[Ordinal(0)] [RED("("hack_started")] 		public CBool Hack_started { get; set;}

		[Ordinal(0)] [RED("("hack_fromAreaEnter")] 		public CBool Hack_fromAreaEnter { get; set;}

		public W3NoticeBoard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3NoticeBoard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}