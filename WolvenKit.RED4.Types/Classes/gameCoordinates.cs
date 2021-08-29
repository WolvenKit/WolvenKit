using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCoordinates : RedBaseClass
	{
		private CInt32 _latitude;
		private CInt32 _longitude;

		[Ordinal(0)] 
		[RED("latitude")] 
		public CInt32 Latitude
		{
			get => GetProperty(ref _latitude);
			set => SetProperty(ref _latitude, value);
		}

		[Ordinal(1)] 
		[RED("longitude")] 
		public CInt32 Longitude
		{
			get => GetProperty(ref _longitude);
			set => SetProperty(ref _longitude, value);
		}
	}
}
