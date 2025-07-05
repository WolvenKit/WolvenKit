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
			VolumeBox = new Box { Min = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, Max = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
