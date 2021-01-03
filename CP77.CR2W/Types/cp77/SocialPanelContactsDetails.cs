using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsDetails : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("ContactAvatarRef")] public inkImageWidgetReference ContactAvatarRef { get; set; }
		[Ordinal(1)]  [RED("ContactDescriptionRef")] public inkTextWidgetReference ContactDescriptionRef { get; set; }
		[Ordinal(2)]  [RED("ContactNameRef")] public inkTextWidgetReference ContactNameRef { get; set; }

		public SocialPanelContactsDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
