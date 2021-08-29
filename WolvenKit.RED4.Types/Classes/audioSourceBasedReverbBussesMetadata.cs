using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioSourceBasedReverbBussesMetadata : audioAudioMetadata
	{
		private CName _exterior;
		private CName _interiorLarge;
		private CName _interiorMedium;
		private CName _interiorSmall;

		[Ordinal(1)] 
		[RED("exterior")] 
		public CName Exterior
		{
			get => GetProperty(ref _exterior);
			set => SetProperty(ref _exterior, value);
		}

		[Ordinal(2)] 
		[RED("interiorLarge")] 
		public CName InteriorLarge
		{
			get => GetProperty(ref _interiorLarge);
			set => SetProperty(ref _interiorLarge, value);
		}

		[Ordinal(3)] 
		[RED("interiorMedium")] 
		public CName InteriorMedium
		{
			get => GetProperty(ref _interiorMedium);
			set => SetProperty(ref _interiorMedium, value);
		}

		[Ordinal(4)] 
		[RED("interiorSmall")] 
		public CName InteriorSmall
		{
			get => GetProperty(ref _interiorSmall);
			set => SetProperty(ref _interiorSmall, value);
		}
	}
}
