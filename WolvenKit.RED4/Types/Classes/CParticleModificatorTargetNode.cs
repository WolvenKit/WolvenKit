using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorTargetNode : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("killRadius")] 
		public CHandle<IEvaluatorFloat> KillRadius
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("maxForce")] 
		public CFloat MaxForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CParticleModificatorTargetNode()
		{
			EditorName = "Target node";
			EditorGroup = "Velocity";
			IsEnabled = true;
			MaxForce = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
