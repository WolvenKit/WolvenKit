using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldHeatmapSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("volumeBox")] 
		public Box VolumeBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(1)] 
		[RED("verticalResolution")] 
		public CUInt32 VerticalResolution
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("horizontalResolution")] 
		public CUInt32 HorizontalResolution
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldHeatmapSetup()
		{
			VolumeBox = new() { Min = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, Max = new() { X = -340282346638528859811704183484516925440.000000F, Y = -340282346638528859811704183484516925440.000000F, Z = -340282346638528859811704183484516925440.000000F, W = -340282346638528859811704183484516925440.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
