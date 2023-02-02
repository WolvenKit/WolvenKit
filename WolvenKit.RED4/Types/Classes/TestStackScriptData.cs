using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TestStackScriptData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("testVar")] 
		public CInt32 TestVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("anotherVar")] 
		public CName AnotherVar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public TestStackScriptData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
