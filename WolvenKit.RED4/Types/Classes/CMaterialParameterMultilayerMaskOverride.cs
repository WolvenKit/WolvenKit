using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterMultilayerMaskOverride : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("mask")] 
		public CResourceReference<Multilayer_Mask> Mask
		{
			get => GetPropertyValue<CResourceReference<Multilayer_Mask>>();
			set => SetPropertyValue<CResourceReference<Multilayer_Mask>>(value);
		}

		public CMaterialParameterMultilayerMaskOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
