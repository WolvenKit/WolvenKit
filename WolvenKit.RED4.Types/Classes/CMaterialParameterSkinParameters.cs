using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterSkinParameters : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("skinProfile")] 
		public CResourceReference<CSkinProfile> SkinProfile
		{
			get => GetPropertyValue<CResourceReference<CSkinProfile>>();
			set => SetPropertyValue<CResourceReference<CSkinProfile>>(value);
		}

		public CMaterialParameterSkinParameters()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
