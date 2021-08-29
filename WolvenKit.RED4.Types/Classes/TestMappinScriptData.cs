using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestMappinScriptData : gamemappinsMappinScriptData
	{
		private CInt32 _test;

		[Ordinal(1)] 
		[RED("test")] 
		public CInt32 Test
		{
			get => GetProperty(ref _test);
			set => SetProperty(ref _test, value);
		}
	}
}
