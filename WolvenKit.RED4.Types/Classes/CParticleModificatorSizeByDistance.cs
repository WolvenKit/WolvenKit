using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorSizeByDistance : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("nearDistanceRangeStart")] 
		public CHandle<IEvaluatorFloat> NearDistanceRangeStart
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("nearDistanceRangeEnd")] 
		public CHandle<IEvaluatorFloat> NearDistanceRangeEnd
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("nearDistanceSizeMultiplier")] 
		public CHandle<IEvaluatorFloat> NearDistanceSizeMultiplier
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("farDistanceRangeStart")] 
		public CHandle<IEvaluatorFloat> FarDistanceRangeStart
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("farDistanceRangeEnd")] 
		public CHandle<IEvaluatorFloat> FarDistanceRangeEnd
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("farDistanceSizeMultiplier")] 
		public CHandle<IEvaluatorFloat> FarDistanceSizeMultiplier
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleModificatorSizeByDistance()
		{
			EditorName = "Size by distance";
			EditorGroup = "Size";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
