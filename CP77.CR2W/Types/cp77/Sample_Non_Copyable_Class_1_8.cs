using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Non_Copyable_Class_1_8 : CVariable
	{
		public Sample_Non_Copyable_Class_1_8(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
