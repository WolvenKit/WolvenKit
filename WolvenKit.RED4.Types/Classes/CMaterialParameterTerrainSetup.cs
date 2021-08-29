using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterTerrainSetup : CMaterialParameter
	{
		private CResourceReference<CTerrainSetup> _setup;

		[Ordinal(2)] 
		[RED("setup")] 
		public CResourceReference<CTerrainSetup> Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}
	}
}
