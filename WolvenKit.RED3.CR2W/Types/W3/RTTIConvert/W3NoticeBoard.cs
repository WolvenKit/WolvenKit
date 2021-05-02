using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3NoticeBoard : CR4MapPinEntity
	{
		[Ordinal(1)] [RED("visited")] 		public CBool Visited { get; set;}

		[Ordinal(2)] [RED("addedNotes", 2,0)] 		public CArray<ErrandDetailsList> AddedNotes { get; set;}

		[Ordinal(3)] [RED("fluffNotices", 2,0)] 		public CArray<CString> FluffNotices { get; set;}

		[Ordinal(4)] [RED("entitiesToBeShown", 2,0)] 		public CArray<CName> EntitiesToBeShown { get; set;}

		[Ordinal(5)] [RED("questEntitiesToBeShown", 2,0)] 		public CArray<CName> QuestEntitiesToBeShown { get; set;}

		[Ordinal(6)] [RED("questNonActorEntitiesToBeShown", 2,0)] 		public CArray<CName> QuestNonActorEntitiesToBeShown { get; set;}

		[Ordinal(7)] [RED("InteractionSpawnDelayTime")] 		public CFloat InteractionSpawnDelayTime { get; set;}

		[Ordinal(8)] [RED("backgroundOverride")] 		public CString BackgroundOverride { get; set;}

		[Ordinal(9)] [RED("factAddedOnDiscovery")] 		public CName FactAddedOnDiscovery { get; set;}

		[Ordinal(10)] [RED("noticeboardDisabled")] 		public CBool NoticeboardDisabled { get; set;}

		[Ordinal(11)] [RED("activeErrands", 2,0)] 		public CArray<ErrandDetailsList> ActiveErrands { get; set;}

		[Ordinal(12)] [RED("updatingInteraction")] 		public CBool UpdatingInteraction { get; set;}

		[Ordinal(13)] [RED("errandPositionName")] 		public CString ErrandPositionName { get; set;}

		[Ordinal(14)] [RED("MAX_DISPLAYED_ERRANDS")] 		public CInt32 MAX_DISPLAYED_ERRANDS { get; set;}

		[Ordinal(15)] [RED("lastTimeInteracted")] 		public GameTime LastTimeInteracted { get; set;}

		[Ordinal(16)] [RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(17)] [RED("hack_updateTriesLeft")] 		public CInt32 Hack_updateTriesLeft { get; set;}

		[Ordinal(18)] [RED("hack_isTryingUpdate")] 		public CBool Hack_isTryingUpdate { get; set;}

		[Ordinal(19)] [RED("hack_started")] 		public CBool Hack_started { get; set;}

		[Ordinal(20)] [RED("hack_fromAreaEnter")] 		public CBool Hack_fromAreaEnter { get; set;}

		public W3NoticeBoard(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3NoticeBoard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}