using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestStackScriptData : CVariable
	{
		private CInt32 _testVar;
		private CName _anotherVar;

		[Ordinal(0)] 
		[RED("testVar")] 
		public CInt32 TestVar
		{
			get => GetProperty(ref _testVar);
			set => SetProperty(ref _testVar, value);
		}

		[Ordinal(1)] 
		[RED("anotherVar")] 
		public CName AnotherVar
		{
			get => GetProperty(ref _anotherVar);
			set => SetProperty(ref _anotherVar, value);
		}

		public TestStackScriptData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
