using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestMappinScriptData : gamemappinsMappinScriptData
	{
		[Ordinal(1)] 
		[RED("test")] 
		public CInt32 Test
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
