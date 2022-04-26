using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterFoliageParameters : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("foliageProfile")] 
		public CResourceReference<CFoliageProfile> FoliageProfile
		{
			get => GetPropertyValue<CResourceReference<CFoliageProfile>>();
			set => SetPropertyValue<CResourceReference<CFoliageProfile>>(value);
		}

		public CMaterialParameterFoliageParameters()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
