using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsListItem : inkToggleController
	{
		[Ordinal(0)]  [RED("Label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("ContactInfo")] public SocialPanelContactInfo ContactInfo { get; set; }

		public SocialPanelContactsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
