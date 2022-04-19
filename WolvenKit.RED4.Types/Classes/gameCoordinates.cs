using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCoordinates : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("latitude")] 
		public CInt32 Latitude
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("longitude")] 
		public CInt32 Longitude
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameCoordinates()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
