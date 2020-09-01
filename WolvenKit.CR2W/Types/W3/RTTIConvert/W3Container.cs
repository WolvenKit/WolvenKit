using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Container : W3LockableEntity
	{
		[Ordinal(0)] [RED("("shouldBeFullySaved")] 		public CBool ShouldBeFullySaved { get; set;}

		[Ordinal(0)] [RED("("isDynamic")] 		public CBool IsDynamic { get; set;}

		[Ordinal(0)] [RED("("skipInventoryPanel")] 		public CBool SkipInventoryPanel { get; set;}

		[Ordinal(0)] [RED("("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		[Ordinal(0)] [RED("("factOnContainerOpened")] 		public CString FactOnContainerOpened { get; set;}

		[Ordinal(0)] [RED("("usedByCiri")] 		public CBool UsedByCiri { get; set;}

		[Ordinal(0)] [RED("("allowToInjectBalanceItems")] 		public CBool AllowToInjectBalanceItems { get; set;}

		[Ordinal(0)] [RED("("disableLooting")] 		public CBool DisableLooting { get; set;}

		[Ordinal(0)] [RED("("disableStealing")] 		public CBool DisableStealing { get; set;}

		[Ordinal(0)] [RED("("mergeNotification")] 		public CBool MergeNotification { get; set;}

		[Ordinal(0)] [RED("("checkedForBonusMoney")] 		public CBool CheckedForBonusMoney { get; set;}

		[Ordinal(0)] [RED("("usedByClueStash")] 		public EntityHandle UsedByClueStash { get; set;}

		[Ordinal(0)] [RED("("disableFocusHighlightControl")] 		public CBool DisableFocusHighlightControl { get; set;}

		[Ordinal(0)] [RED("("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[Ordinal(0)] [RED("("lootInteractionComponent")] 		public CHandle<CInteractionComponent> LootInteractionComponent { get; set;}

		[Ordinal(0)] [RED("("isPlayingInteractionAnim")] 		public CBool IsPlayingInteractionAnim { get; set;}

		[Ordinal(0)] [RED("("QUEST_HIGHLIGHT_FX")] 		public CName QUEST_HIGHLIGHT_FX { get; set;}

		[Ordinal(0)] [RED("("spoonCollectorTested")] 		public CBool SpoonCollectorTested { get; set;}

		[Ordinal(0)] [RED("("SKIP_NO_DROP_NO_SHOW")] 		public CBool SKIP_NO_DROP_NO_SHOW { get; set;}

		public W3Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Container(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}