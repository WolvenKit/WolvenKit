using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class toolsMessage : CVariable
	{
		[Ordinal(0)] [RED("severity")] public CEnum<toolsMessageSeverity> Severity { get; set; }
		[Ordinal(1)] [RED("created")] public CInt64 Created { get; set; }
		[Ordinal(2)] [RED("location")] public CHandle<toolsIMessageLocation> Location { get; set; }
		[Ordinal(3)] [RED("tokens")] public CArray<CHandle<toolsIMessageToken>> Tokens { get; set; }

		public toolsMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
