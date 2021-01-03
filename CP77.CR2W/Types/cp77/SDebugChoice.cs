using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
