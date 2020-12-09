using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Container : W3LockableEntity
	{
		[Ordinal(1)] [RED("shouldBeFullySaved")] 		public CBool ShouldBeFullySaved { get; set;}

		[Ordinal(2)] [RED("isDynamic")] 		public CBool IsDynamic { get; set;}

		[Ordinal(3)] [RED("skipInventoryPanel")] 		public CBool SkipInventoryPanel { get; set;}

		[Ordinal(4)] [RED("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		[Ordinal(5)] [RED("factOnContainerOpened")] 		public CString FactOnContainerOpened { get; set;}

		[Ordinal(6)] [RED("usedByCiri")] 		public CBool UsedByCiri { get; set;}

		[Ordinal(7)] [RED("allowToInjectBalanceItems")] 		public CBool AllowToInjectBalanceItems { get; set;}

		[Ordinal(8)] [RED("disableLooting")] 		public CBool DisableLooting { get; set;}

		[Ordinal(9)] [RED("disableStealing")] 		public CBool DisableStealing { get; set;}

		[Ordinal(10)] [RED("mergeNotification")] 		public CBool MergeNotification { get; set;}

		[Ordinal(11)] [RED("checkedForBonusMoney")] 		public CBool CheckedForBonusMoney { get; set;}

		[Ordinal(12)] [RED("usedByClueStash")] 		public EntityHandle UsedByClueStash { get; set;}

		[Ordinal(13)] [RED("disableFocusHighlightControl")] 		public CBool DisableFocusHighlightControl { get; set;}

		[Ordinal(14)] [RED("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[Ordinal(15)] [RED("lootInteractionComponent")] 		public CHandle<CInteractionComponent> LootInteractionComponent { get; set;}

		[Ordinal(16)] [RED("isPlayingInteractionAnim")] 		public CBool IsPlayingInteractionAnim { get; set;}

		[Ordinal(17)] [RED("QUEST_HIGHLIGHT_FX")] 		public CName QUEST_HIGHLIGHT_FX { get; set;}

		[Ordinal(18)] [RED("spoonCollectorTested")] 		public CBool SpoonCollectorTested { get; set;}

		[Ordinal(19)] [RED("SKIP_NO_DROP_NO_SHOW")] 		public CBool SKIP_NO_DROP_NO_SHOW { get; set;}

		public W3Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Container(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}