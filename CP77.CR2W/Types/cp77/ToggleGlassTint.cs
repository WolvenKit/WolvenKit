using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleGlassTint : ActionBool
	{
		[Ordinal(22)]  [RED("TrueRecord")] public CString TrueRecord { get; set; }
		[Ordinal(23)]  [RED("FalseRecord")] public CString FalseRecord { get; set; }

		public ToggleGlassTint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
