using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questWarningMessage_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(2)]  [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }
		[Ordinal(3)]  [RED("message")] public CString Message { get; set; }
		[Ordinal(4)]  [RED("show")] public CBool Show { get; set; }

		public questWarningMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
