using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDebugChoice : CVariable
	{
		[Ordinal(0)]  [RED("choiceName")] public CName ChoiceName { get; set; }
		[Ordinal(1)]  [RED("factValue")] public CInt32 FactValue { get; set; }
		[Ordinal(2)]  [RED("factmode")] public CEnum<EVarDBMode> Factmode { get; set; }

		public SDebugChoice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
