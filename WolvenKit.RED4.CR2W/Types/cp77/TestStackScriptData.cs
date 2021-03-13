using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestStackScriptData : CVariable
	{
		[Ordinal(0)] [RED("testVar")] public CInt32 TestVar { get; set; }
		[Ordinal(1)] [RED("anotherVar")] public CName AnotherVar { get; set; }

		public TestStackScriptData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
