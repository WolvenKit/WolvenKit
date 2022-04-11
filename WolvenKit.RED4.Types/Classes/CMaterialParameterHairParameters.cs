using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterHairParameters : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("hairProfile")] 
		public CResourceReference<CHairProfile> HairProfile
		{
			get => GetPropertyValue<CResourceReference<CHairProfile>>();
			set => SetPropertyValue<CResourceReference<CHairProfile>>(value);
		}

		public CMaterialParameterHairParameters()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
