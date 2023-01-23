using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVehicleSystem : gameIVehicleSystem
	{
		[Ordinal(0)] 
		[RED("restrictionTags")] 
		public CArray<CName> RestrictionTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameVehicleSystem()
		{
			RestrictionTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
