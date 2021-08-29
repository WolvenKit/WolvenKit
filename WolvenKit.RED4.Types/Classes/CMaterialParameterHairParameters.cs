using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterHairParameters : CMaterialParameter
	{
		private CResourceReference<CHairProfile> _hairProfile;

		[Ordinal(2)] 
		[RED("hairProfile")] 
		public CResourceReference<CHairProfile> HairProfile
		{
			get => GetProperty(ref _hairProfile);
			set => SetProperty(ref _hairProfile, value);
		}
	}
}
