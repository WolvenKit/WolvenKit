using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerSize : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("size")] 
		public CHandle<IEvaluatorVector> Size
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CParticleInitializerSize()
		{
			EditorName = "Initial size";
			EditorGroup = "Size";
			IsEnabled = true;
			Scale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
