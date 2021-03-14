using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDisplayMessageBox_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("title")] public CString Title { get; set; }
		[Ordinal(1)] [RED("message")] public CString Message { get; set; }
		[Ordinal(2)] [RED("localizedTitle")] public LocalizationString LocalizedTitle { get; set; }
		[Ordinal(3)] [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }

		public questDisplayMessageBox_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
