using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemFogVolume : effectTrackItem
	{
		private CUInt8 _priority;
		private CFloat _densityFalloff;
		private CFloat _blendFalloff;
		private CHandle<IEvaluatorFloat> _density;
		private CHandle<IEvaluatorVector> _size;
		private CHandle<IEvaluatorColor> _color;

		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(4)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get => GetProperty(ref _densityFalloff);
			set => SetProperty(ref _densityFalloff, value);
		}

		[Ordinal(5)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get => GetProperty(ref _blendFalloff);
			set => SetProperty(ref _blendFalloff, value);
		}

		[Ordinal(6)] 
		[RED("density")] 
		public CHandle<IEvaluatorFloat> Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(7)] 
		[RED("size")] 
		public CHandle<IEvaluatorVector> Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(8)] 
		[RED("color")] 
		public CHandle<IEvaluatorColor> Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}
	}
}
