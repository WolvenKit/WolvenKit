using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorColorOverLife : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("color")] 
		public CHandle<IEvaluatorColor> Color
		{
			get => GetPropertyValue<CHandle<IEvaluatorColor>>();
			set => SetPropertyValue<CHandle<IEvaluatorColor>>(value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorColorOverLife()
		{
			EditorName = "Color over life";
			EditorGroup = "Material";
			IsEnabled = true;
			Modulate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
