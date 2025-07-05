using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TestMappinScriptData : gamemappinsMappinScriptData
	{
		[Ordinal(1)] 
		[RED("test")] 
		public CInt32 Test
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TestMappinScriptData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
