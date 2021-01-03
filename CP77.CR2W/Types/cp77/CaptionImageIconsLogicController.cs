using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CaptionImageIconsLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("CheckBackground")] public inkWidgetReference CheckBackground { get; set; }
		[Ordinal(1)]  [RED("CheckBackgroundFail")] public inkWidgetReference CheckBackgroundFail { get; set; }
		[Ordinal(2)]  [RED("CheckHolder")] public inkCompoundWidgetReference CheckHolder { get; set; }
		[Ordinal(3)]  [RED("CheckIcon")] public inkImageWidgetReference CheckIcon { get; set; }
		[Ordinal(4)]  [RED("CheckText")] public inkTextWidgetReference CheckText { get; set; }
		[Ordinal(5)]  [RED("GenericHolder")] public inkCompoundWidgetReference GenericHolder { get; set; }
		[Ordinal(6)]  [RED("GenericIcon")] public inkImageWidgetReference GenericIcon { get; set; }
		[Ordinal(7)]  [RED("LifeBackground")] public inkWidgetReference LifeBackground { get; set; }
		[Ordinal(8)]  [RED("LifeBackgroundFail")] public inkWidgetReference LifeBackgroundFail { get; set; }
		[Ordinal(9)]  [RED("LifeDescriptionText")] public inkTextWidgetReference LifeDescriptionText { get; set; }
		[Ordinal(10)]  [RED("LifeHolder")] public inkCompoundWidgetReference LifeHolder { get; set; }
		[Ordinal(11)]  [RED("LifeIcon")] public inkImageWidgetReference LifeIcon { get; set; }
		[Ordinal(12)]  [RED("PayBackground")] public inkWidgetReference PayBackground { get; set; }
		[Ordinal(13)]  [RED("PayBackgroundFail")] public inkWidgetReference PayBackgroundFail { get; set; }
		[Ordinal(14)]  [RED("PayHolder")] public inkCompoundWidgetReference PayHolder { get; set; }
		[Ordinal(15)]  [RED("PayIcon")] public inkImageWidgetReference PayIcon { get; set; }
		[Ordinal(16)]  [RED("PayText")] public inkTextWidgetReference PayText { get; set; }

		public CaptionImageIconsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
