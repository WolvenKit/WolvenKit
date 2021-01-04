using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAICommandNodeFunction : CVariable
	{
		[Ordinal(0)]  [RED("commandCategory")] public CName CommandCategory { get; set; }
		[Ordinal(1)]  [RED("friendlyName")] public CString FriendlyName { get; set; }
		[Ordinal(2)]  [RED("nodeColor")] public CColor NodeColor { get; set; }
		[Ordinal(3)]  [RED("nodeType")] public CName NodeType { get; set; }
		[Ordinal(4)]  [RED("order")] public CUInt32 Order { get; set; }
		[Ordinal(5)]  [RED("paramsType")] public CName ParamsType { get; set; }

		public questAICommandNodeFunction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
