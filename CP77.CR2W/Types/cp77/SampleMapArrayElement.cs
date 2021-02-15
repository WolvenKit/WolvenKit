using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SampleMapArrayElement : CVariable
	{
		[Ordinal(0)] [RED("myKey")] public CUInt32 MyKey { get; set; }
		[Ordinal(1)] [RED("someStringProperty")] public CString SomeStringProperty { get; set; }
		[Ordinal(2)] [RED("someArrayProperty")] public CArray<CString> SomeArrayProperty { get; set; }

		public SampleMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
