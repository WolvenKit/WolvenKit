using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemAddedNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("titleRef")] public inkTextWidgetReference TitleRef { get; set; }
		[Ordinal(1)]  [RED("textRef")] public inkTextWidgetReference TextRef { get; set; }
		[Ordinal(2)]  [RED("actionLabelRef")] public inkTextWidgetReference ActionLabelRef { get; set; }
		[Ordinal(3)]  [RED("actionRef")] public inkWidgetReference ActionRef { get; set; }
		[Ordinal(4)]  [RED("blockAction")] public CBool BlockAction { get; set; }
		[Ordinal(5)]  [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(6)]  [RED("data")] public CHandle<gameuiGenericNotificationViewData> Data { get; set; }
		[Ordinal(7)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(8)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(9)]  [RED("itemImage")] public inkImageWidgetReference ItemImage { get; set; }
		[Ordinal(10)]  [RED("rarityBar")] public inkWidgetReference RarityBar { get; set; }
		[Ordinal(11)]  [RED("itemIconGender")] public CEnum<gameItemIconGender> ItemIconGender { get; set; }
		[Ordinal(12)]  [RED("animationName")] public CName AnimationName { get; set; }

		public ItemAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
