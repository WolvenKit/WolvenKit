using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CaptionImageIconsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("LifeIcon")] public inkImageWidgetReference LifeIcon { get; set; }
		[Ordinal(2)] [RED("CheckIcon")] public inkImageWidgetReference CheckIcon { get; set; }
		[Ordinal(3)] [RED("GenericIcon")] public inkImageWidgetReference GenericIcon { get; set; }
		[Ordinal(4)] [RED("PayIcon")] public inkImageWidgetReference PayIcon { get; set; }
		[Ordinal(5)] [RED("LifeHolder")] public inkCompoundWidgetReference LifeHolder { get; set; }
		[Ordinal(6)] [RED("CheckHolder")] public inkCompoundWidgetReference CheckHolder { get; set; }
		[Ordinal(7)] [RED("GenericHolder")] public inkCompoundWidgetReference GenericHolder { get; set; }
		[Ordinal(8)] [RED("PayHolder")] public inkCompoundWidgetReference PayHolder { get; set; }
		[Ordinal(9)] [RED("LifeDescriptionText")] public inkTextWidgetReference LifeDescriptionText { get; set; }
		[Ordinal(10)] [RED("CheckText")] public inkTextWidgetReference CheckText { get; set; }
		[Ordinal(11)] [RED("PayText")] public inkTextWidgetReference PayText { get; set; }
		[Ordinal(12)] [RED("LifeBackground")] public inkWidgetReference LifeBackground { get; set; }
		[Ordinal(13)] [RED("LifeBackgroundFail")] public inkWidgetReference LifeBackgroundFail { get; set; }
		[Ordinal(14)] [RED("CheckBackground")] public inkWidgetReference CheckBackground { get; set; }
		[Ordinal(15)] [RED("CheckBackgroundFail")] public inkWidgetReference CheckBackgroundFail { get; set; }
		[Ordinal(16)] [RED("PayBackground")] public inkWidgetReference PayBackground { get; set; }
		[Ordinal(17)] [RED("PayBackgroundFail")] public inkWidgetReference PayBackgroundFail { get; set; }

		public CaptionImageIconsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
