using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterTerrainSetup : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("setup")] 
		public CResourceReference<CTerrainSetup> Setup
		{
			get => GetPropertyValue<CResourceReference<CTerrainSetup>>();
			set => SetPropertyValue<CResourceReference<CTerrainSetup>>(value);
		}
	}
}
