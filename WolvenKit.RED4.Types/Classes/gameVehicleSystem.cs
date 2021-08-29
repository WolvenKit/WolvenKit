using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVehicleSystem : gameIVehicleSystem
	{
		private CArray<CName> _restrictionTags;

		[Ordinal(0)] 
		[RED("restrictionTags")] 
		public CArray<CName> RestrictionTags
		{
			get => GetProperty(ref _restrictionTags);
			set => SetProperty(ref _restrictionTags, value);
		}
	}
}
