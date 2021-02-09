using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CaptionImageIconsLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("LifeIcon")] public inkImageWidgetReference LifeIcon { get; set; }
		[Ordinal(1)]  [RED("CheckIcon")] public inkImageWidgetReference CheckIcon { get; set; }
		[Ordinal(2)]  [RED("GenericIcon")] public inkImageWidgetReference GenericIcon { get; set; }
		[Ordinal(3)]  [RED("PayIcon")] public inkImageWidgetReference PayIcon { get; set; }
		[Ordinal(4)]  [RED("LifeHolder")] public inkCompoundWidgetReference LifeHolder { get; set; }
		[Ordinal(5)]  [RED("CheckHolder")] public inkCompoundWidgetReference CheckHolder { get; set; }
		[Ordinal(6)]  [RED("GenericHolder")] public inkCompoundWidgetReference GenericHolder { get; set; }
		[Ordinal(7)]  [RED("PayHolder")] public inkCompoundWidgetReference PayHolder { get; set; }
		[Ordinal(8)]  [RED("LifeDescriptionText")] public inkTextWidgetReference LifeDescriptionText { get; set; }
		[Ordinal(9)]  [RED("CheckText")] public inkTextWidgetReference CheckText { get; set; }
		[Ordinal(10)]  [RED("PayText")] public inkTextWidgetReference PayText { get; set; }
		[Ordinal(11)]  [RED("LifeBackground")] public inkWidgetReference LifeBackground { get; set; }
		[Ordinal(12)]  [RED("LifeBackgroundFail")] public inkWidgetReference LifeBackgroundFail { get; set; }
		[Ordinal(13)]  [RED("CheckBackground")] public inkWidgetReference CheckBackground { get; set; }
		[Ordinal(14)]  [RED("CheckBackgroundFail")] public inkWidgetReference CheckBackgroundFail { get; set; }
		[Ordinal(15)]  [RED("PayBackground")] public inkWidgetReference PayBackground { get; set; }
		[Ordinal(16)]  [RED("PayBackgroundFail")] public inkWidgetReference PayBackgroundFail { get; set; }

		public CaptionImageIconsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
