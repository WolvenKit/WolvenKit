using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterMultilayerSetup : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("setup")] 
		public CResourceReference<Multilayer_Setup> Setup
		{
			get => GetPropertyValue<CResourceReference<Multilayer_Setup>>();
			set => SetPropertyValue<CResourceReference<Multilayer_Setup>>(value);
		}
	}
}
