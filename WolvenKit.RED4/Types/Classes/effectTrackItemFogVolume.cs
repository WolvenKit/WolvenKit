using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemFogVolume : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("density")] 
		public CHandle<IEvaluatorFloat> Density
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("size")] 
		public CHandle<IEvaluatorVector> Size
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(8)] 
		[RED("color")] 
		public CHandle<IEvaluatorColor> Color
		{
			get => GetPropertyValue<CHandle<IEvaluatorColor>>();
			set => SetPropertyValue<CHandle<IEvaluatorColor>>(value);
		}

		public effectTrackItemFogVolume()
		{
			TimeDuration = 1.000000F;
			Priority = 5;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
