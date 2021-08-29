using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldHeatmapSetup : RedBaseClass
	{
		private Box _volumeBox;
		private CUInt32 _verticalResolution;
		private CUInt32 _horizontalResolution;

		[Ordinal(0)] 
		[RED("volumeBox")] 
		public Box VolumeBox
		{
			get => GetProperty(ref _volumeBox);
			set => SetProperty(ref _volumeBox, value);
		}

		[Ordinal(1)] 
		[RED("verticalResolution")] 
		public CUInt32 VerticalResolution
		{
			get => GetProperty(ref _verticalResolution);
			set => SetProperty(ref _verticalResolution, value);
		}

		[Ordinal(2)] 
		[RED("horizontalResolution")] 
		public CUInt32 HorizontalResolution
		{
			get => GetProperty(ref _horizontalResolution);
			set => SetProperty(ref _horizontalResolution, value);
		}
	}
}
