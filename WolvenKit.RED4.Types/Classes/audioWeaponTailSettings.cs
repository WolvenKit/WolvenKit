using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioWeaponTailSettings : audioAudioMetadata
	{
		private CName _interiorDefault;
		private CName _interiorWide;
		private CName _exteriorWide;
		private CName _exteriorUrbanNarrow;
		private CName _exteriorUrbanStreet;
		private CName _exteriorUrbanStreetWide;
		private CName _exteriorUrbanOpen;
		private CName _exteriorUrbanEnclosed;
		private CName _exteriorBadlandsOpen;
		private CName _exteriorBadlandsCanyon;

		[Ordinal(1)] 
		[RED("interiorDefault")] 
		public CName InteriorDefault
		{
			get => GetProperty(ref _interiorDefault);
			set => SetProperty(ref _interiorDefault, value);
		}

		[Ordinal(2)] 
		[RED("interiorWide")] 
		public CName InteriorWide
		{
			get => GetProperty(ref _interiorWide);
			set => SetProperty(ref _interiorWide, value);
		}

		[Ordinal(3)] 
		[RED("exteriorWide")] 
		public CName ExteriorWide
		{
			get => GetProperty(ref _exteriorWide);
			set => SetProperty(ref _exteriorWide, value);
		}

		[Ordinal(4)] 
		[RED("exteriorUrbanNarrow")] 
		public CName ExteriorUrbanNarrow
		{
			get => GetProperty(ref _exteriorUrbanNarrow);
			set => SetProperty(ref _exteriorUrbanNarrow, value);
		}

		[Ordinal(5)] 
		[RED("exteriorUrbanStreet")] 
		public CName ExteriorUrbanStreet
		{
			get => GetProperty(ref _exteriorUrbanStreet);
			set => SetProperty(ref _exteriorUrbanStreet, value);
		}

		[Ordinal(6)] 
		[RED("exteriorUrbanStreetWide")] 
		public CName ExteriorUrbanStreetWide
		{
			get => GetProperty(ref _exteriorUrbanStreetWide);
			set => SetProperty(ref _exteriorUrbanStreetWide, value);
		}

		[Ordinal(7)] 
		[RED("exteriorUrbanOpen")] 
		public CName ExteriorUrbanOpen
		{
			get => GetProperty(ref _exteriorUrbanOpen);
			set => SetProperty(ref _exteriorUrbanOpen, value);
		}

		[Ordinal(8)] 
		[RED("exteriorUrbanEnclosed")] 
		public CName ExteriorUrbanEnclosed
		{
			get => GetProperty(ref _exteriorUrbanEnclosed);
			set => SetProperty(ref _exteriorUrbanEnclosed, value);
		}

		[Ordinal(9)] 
		[RED("exteriorBadlandsOpen")] 
		public CName ExteriorBadlandsOpen
		{
			get => GetProperty(ref _exteriorBadlandsOpen);
			set => SetProperty(ref _exteriorBadlandsOpen, value);
		}

		[Ordinal(10)] 
		[RED("exteriorBadlandsCanyon")] 
		public CName ExteriorBadlandsCanyon
		{
			get => GetProperty(ref _exteriorBadlandsCanyon);
			set => SetProperty(ref _exteriorBadlandsCanyon, value);
		}
	}
}
