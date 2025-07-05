using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterGradient : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("gradient")] 
		public CResourceReference<CGradient> Gradient
		{
			get => GetPropertyValue<CResourceReference<CGradient>>();
			set => SetPropertyValue<CResourceReference<CGradient>>(value);
		}

		public CMaterialParameterGradient()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
