using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questDisplayMessageBox_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }
		[Ordinal(1)]  [RED("localizedTitle")] public LocalizationString LocalizedTitle { get; set; }
		[Ordinal(2)]  [RED("message")] public CString Message { get; set; }
		[Ordinal(3)]  [RED("title")] public CString Title { get; set; }

		public questDisplayMessageBox_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
