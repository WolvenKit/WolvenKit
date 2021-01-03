using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TestStackScriptData : CVariable
	{
		[Ordinal(0)]  [RED("anotherVar")] public CName AnotherVar { get; set; }
		[Ordinal(1)]  [RED("testVar")] public CInt32 TestVar { get; set; }

		public TestStackScriptData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
