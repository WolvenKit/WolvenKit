using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterSkinParameters : CMaterialParameter
	{
		private CResourceReference<CSkinProfile> _skinProfile;

		[Ordinal(2)] 
		[RED("skinProfile")] 
		public CResourceReference<CSkinProfile> SkinProfile
		{
			get => GetProperty(ref _skinProfile);
			set => SetProperty(ref _skinProfile, value);
		}
	}
}
