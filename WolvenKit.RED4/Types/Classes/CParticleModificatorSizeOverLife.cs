using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorSizeOverLife : IParticleModificator
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

		[Ordinal(6)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorSizeOverLife()
		{
			EditorName = "Size over life";
			EditorGroup = "Size";
			IsEnabled = true;
			Scale = 1.000000F;
			Modulate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
