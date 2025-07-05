using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorTarget : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("position")] 
		public CHandle<IEvaluatorVector> Position
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("killRadius")] 
		public CHandle<IEvaluatorFloat> KillRadius
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("maxForce")] 
		public CFloat MaxForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CParticleModificatorTarget()
		{
			EditorName = "Target";
			EditorGroup = "Velocity";
			IsEnabled = true;
			MaxForce = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
