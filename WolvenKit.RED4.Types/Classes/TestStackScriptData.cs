using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestStackScriptData : RedBaseClass
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
	}
}
