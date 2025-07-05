using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorOrbit : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("offset")] 
		public CHandle<IEvaluatorVector> Offset
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("frequency")] 
		public CHandle<IEvaluatorVector> Frequency
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(6)] 
		[RED("phase")] 
		public CHandle<IEvaluatorVector> Phase
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(7)] 
		[RED("overridePosition")] 
		public CBool OverridePosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorOrbit()
		{
			EditorName = "Orbit";
			EditorGroup = "Orbit";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
