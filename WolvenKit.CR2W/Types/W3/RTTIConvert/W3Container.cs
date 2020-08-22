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
		[RED("shouldBeFullySaved")] 		public CBool ShouldBeFullySaved { get; set;}

		[RED("isDynamic")] 		public CBool IsDynamic { get; set;}

		[RED("skipInventoryPanel")] 		public CBool SkipInventoryPanel { get; set;}

		[RED("focusModeHighlight")] 		public CEnum<EFocusModeVisibility> FocusModeHighlight { get; set;}

		[RED("factOnContainerOpened")] 		public CString FactOnContainerOpened { get; set;}

		[RED("usedByCiri")] 		public CBool UsedByCiri { get; set;}

		[RED("allowToInjectBalanceItems")] 		public CBool AllowToInjectBalanceItems { get; set;}

		[RED("disableLooting")] 		public CBool DisableLooting { get; set;}

		[RED("disableStealing")] 		public CBool DisableStealing { get; set;}

		[RED("mergeNotification")] 		public CBool MergeNotification { get; set;}

		[RED("checkedForBonusMoney")] 		public CBool CheckedForBonusMoney { get; set;}

		[RED("usedByClueStash")] 		public EntityHandle UsedByClueStash { get; set;}

		[RED("disableFocusHighlightControl")] 		public CBool DisableFocusHighlightControl { get; set;}

		[RED("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[RED("lootInteractionComponent")] 		public CHandle<CInteractionComponent> LootInteractionComponent { get; set;}

		[RED("isPlayingInteractionAnim")] 		public CBool IsPlayingInteractionAnim { get; set;}

		[RED("QUEST_HIGHLIGHT_FX")] 		public CName QUEST_HIGHLIGHT_FX { get; set;}

		[RED("spoonCollectorTested")] 		public CBool SpoonCollectorTested { get; set;}

		[RED("SKIP_NO_DROP_NO_SHOW")] 		public CBool SKIP_NO_DROP_NO_SHOW { get; set;}

		public W3Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Container(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}