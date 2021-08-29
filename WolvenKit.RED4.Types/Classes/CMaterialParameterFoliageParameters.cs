using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterFoliageParameters : CMaterialParameter
	{
		private CResourceReference<CFoliageProfile> _foliageProfile;

		[Ordinal(2)] 
		[RED("foliageProfile")] 
		public CResourceReference<CFoliageProfile> FoliageProfile
		{
			get => GetProperty(ref _foliageProfile);
			set => SetProperty(ref _foliageProfile, value);
		}
	}
}
