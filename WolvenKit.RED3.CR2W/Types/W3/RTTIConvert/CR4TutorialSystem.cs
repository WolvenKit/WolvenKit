using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4TutorialSystem : IGameSystem
	{
		[Ordinal(1)] [RED("needsTickEvent")] 		public CBool NeedsTickEvent { get; set;}

		[Ordinal(2)] [RED("currentlyShownTutorialIndex")] 		public CInt32 CurrentlyShownTutorialIndex { get; set;}

		[Ordinal(3)] [RED("queuedTutorials", 2,0)] 		public CArray<STutorialMessage> QueuedTutorials { get; set;}

		[Ordinal(4)] [RED("m_tutorialHintDataObj")] 		public CHandle<W3TutorialPopupData> M_tutorialHintDataObj { get; set;}

		[Ordinal(5)] [RED("delayedQueuedTutorialShowTime")] 		public CFloat DelayedQueuedTutorialShowTime { get; set;}

		[Ordinal(6)] [RED("hasDelayedTutorial")] 		public CBool HasDelayedTutorial { get; set;}

		[Ordinal(7)] [RED("showNextHintInstantly")] 		public CBool ShowNextHintInstantly { get; set;}

		[Ordinal(8)] [RED("enableMenuRestrictions")] 		public CBool EnableMenuRestrictions { get; set;}

		[Ordinal(9)] [RED("allowedMenusList", 2,0)] 		public CArray<CName> AllowedMenusList { get; set;}

		[Ordinal(10)] [RED("uiHandler")] 		public CHandle<W3TutorialManagerUIHandler> UiHandler { get; set;}

		[Ordinal(11)] [RED("seenTutorials", 2,0)] 		public CArray<CName> SeenTutorials { get; set;}

		[Ordinal(12)] [RED("attackProcessed")] 		public CBool AttackProcessed { get; set;}

		[Ordinal(13)] [RED("testData")] 		public CHandle<W3TutorialPopupData> TestData { get; set;}

		[Ordinal(14)] [RED("hudMessage")] 		public CName HudMessage { get; set;}

		[Ordinal(15)] [RED("invisibleTutorialHint")] 		public CName InvisibleTutorialHint { get; set;}

		[Ordinal(16)] [RED("wereMessagesEnabled")] 		public CBool WereMessagesEnabled { get; set;}

		[Ordinal(17)] [RED("COMBAT_HINT_POS_X")] 		public CFloat COMBAT_HINT_POS_X { get; set;}

		[Ordinal(18)] [RED("COMBAT_HINT_POS_Y")] 		public CFloat COMBAT_HINT_POS_Y { get; set;}

		[Ordinal(19)] [RED("DIALOG_HINT_POS_X")] 		public CFloat DIALOG_HINT_POS_X { get; set;}

		[Ordinal(20)] [RED("DIALOG_HINT_POS_Y")] 		public CFloat DIALOG_HINT_POS_Y { get; set;}

		[Ordinal(21)] [RED("UI_HINT_POS_X")] 		public CFloat UI_HINT_POS_X { get; set;}

		[Ordinal(22)] [RED("UI_HINT_POS_Y")] 		public CFloat UI_HINT_POS_Y { get; set;}

		[Ordinal(23)] [RED("HINT_SHOW_DELAY")] 		public CFloat HINT_SHOW_DELAY { get; set;}

		[Ordinal(24)] [RED("HINT_DURATION_LONG")] 		public CFloat HINT_DURATION_LONG { get; set;}

		[Ordinal(25)] [RED("HINT_DURATION_SHORT")] 		public CFloat HINT_DURATION_SHORT { get; set;}

		public CR4TutorialSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4TutorialSystem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}