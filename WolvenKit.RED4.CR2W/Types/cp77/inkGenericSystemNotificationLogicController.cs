using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGenericSystemNotificationLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("titleTextWidget")] public inkTextWidgetReference TitleTextWidget { get; set; }
		[Ordinal(2)] [RED("descriptionTextWidget")] public inkTextWidgetReference DescriptionTextWidget { get; set; }
		[Ordinal(3)] [RED("additionalDataTextWidget")] public inkTextWidgetReference AdditionalDataTextWidget { get; set; }
		[Ordinal(4)] [RED("introAnimationName")] public CName IntroAnimationName { get; set; }
		[Ordinal(5)] [RED("outroAnimationName")] public CName OutroAnimationName { get; set; }
		[Ordinal(6)] [RED("confirmButton")] public inkWidgetReference ConfirmButton { get; set; }
		[Ordinal(7)] [RED("cancelButton")] public inkWidgetReference CancelButton { get; set; }

		public inkGenericSystemNotificationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
