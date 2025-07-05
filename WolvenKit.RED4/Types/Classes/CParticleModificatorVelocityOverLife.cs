using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorVelocityOverLife : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("velocity")] 
		public CHandle<IEvaluatorVector> Velocity
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

		[Ordinal(7)] 
		[RED("absolute")] 
		public CBool Absolute
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorVelocityOverLife()
		{
			EditorName = "Velocity over life";
			EditorGroup = "Velocity";
			IsEnabled = true;
			Scale = 1.000000F;
			Modulate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
