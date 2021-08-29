using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entFogVolumeComponent : entIVisualComponent
	{
		private CFloat _densityFalloff;
		private CFloat _blendFalloff;
		private CFloat _densityFactor;
		private CColor _color;
		private CFloat _absorption;
		private Vector3 _size;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get => GetProperty(ref _densityFalloff);
			set => SetProperty(ref _densityFalloff, value);
		}

		[Ordinal(9)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get => GetProperty(ref _blendFalloff);
			set => SetProperty(ref _blendFalloff, value);
		}

		[Ordinal(10)] 
		[RED("densityFactor")] 
		public CFloat DensityFactor
		{
			get => GetProperty(ref _densityFactor);
			set => SetProperty(ref _densityFactor, value);
		}

		[Ordinal(11)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(12)] 
		[RED("absorption")] 
		public CFloat Absorption
		{
			get => GetProperty(ref _absorption);
			set => SetProperty(ref _absorption, value);
		}

		[Ordinal(13)] 
		[RED("size")] 
		public Vector3 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(14)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
