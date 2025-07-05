using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorRotation3DOverLife : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorVector> Rotation
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorRotation3DOverLife()
		{
			EditorName = "3D rotation over life";
			EditorGroup = "Rotation";
			IsEnabled = true;
			Modulate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
