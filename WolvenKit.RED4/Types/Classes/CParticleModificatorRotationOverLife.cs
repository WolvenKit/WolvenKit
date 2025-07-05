using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorRotationOverLife : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorFloat> Rotation
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

		public CParticleModificatorRotationOverLife()
		{
			EditorName = "Rotation over life";
			EditorGroup = "Rotation";
			IsEnabled = true;
			Modulate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
