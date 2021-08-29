using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPointCloudEffect : inkIEffect
	{
		private CFloat _repeat;
		private CFloat _offsetX;
		private CFloat _offsetY;
		private CFloat _angle;
		private CFloat _fovScale;
		private CFloat _parallaxDepth;
		private CFloat _depthToOpacity;
		private CFloat _depthToBrightness;

		[Ordinal(2)] 
		[RED("repeat")] 
		public CFloat Repeat
		{
			get => GetProperty(ref _repeat);
			set => SetProperty(ref _repeat, value);
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get => GetProperty(ref _offsetX);
			set => SetProperty(ref _offsetX, value);
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get => GetProperty(ref _offsetY);
			set => SetProperty(ref _offsetY, value);
		}

		[Ordinal(5)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(6)] 
		[RED("fovScale")] 
		public CFloat FovScale
		{
			get => GetProperty(ref _fovScale);
			set => SetProperty(ref _fovScale, value);
		}

		[Ordinal(7)] 
		[RED("parallaxDepth")] 
		public CFloat ParallaxDepth
		{
			get => GetProperty(ref _parallaxDepth);
			set => SetProperty(ref _parallaxDepth, value);
		}

		[Ordinal(8)] 
		[RED("depthToOpacity")] 
		public CFloat DepthToOpacity
		{
			get => GetProperty(ref _depthToOpacity);
			set => SetProperty(ref _depthToOpacity, value);
		}

		[Ordinal(9)] 
		[RED("depthToBrightness")] 
		public CFloat DepthToBrightness
		{
			get => GetProperty(ref _depthToBrightness);
			set => SetProperty(ref _depthToBrightness, value);
		}
	}
}
