using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsListItem : inkToggleController
	{
		[Ordinal(0)]  [RED("ContactInfo")] public SocialPanelContactInfo ContactInfo { get; set; }
		[Ordinal(1)]  [RED("Label")] public inkTextWidgetReference Label { get; set; }

		public SocialPanelContactsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
