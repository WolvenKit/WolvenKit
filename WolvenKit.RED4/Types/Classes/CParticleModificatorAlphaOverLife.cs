using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorAlphaOverLife : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("alpha")] 
		public CHandle<IEvaluatorFloat> Alpha
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorAlphaOverLife()
		{
			EditorName = "Alpha over life";
			EditorGroup = "Material";
			IsEnabled = true;
			Modulate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
