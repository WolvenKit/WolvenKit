using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkStepperData : CVariable
	{
		[Ordinal(0)] [RED("label")] public CString Label { get; set; }
		[Ordinal(1)] [RED("data")] public wCHandle<IScriptable> Data { get; set; }

		public inkStepperData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
