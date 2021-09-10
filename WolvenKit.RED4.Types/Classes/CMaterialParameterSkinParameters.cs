using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterSkinParameters : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("skinProfile")] 
		public CResourceReference<CSkinProfile> SkinProfile
		{
			get => GetPropertyValue<CResourceReference<CSkinProfile>>();
			set => SetPropertyValue<CResourceReference<CSkinProfile>>(value);
		}
	}
}
