using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorAcceleration : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("direction")] 
		public CHandle<IEvaluatorVector> Direction
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CHandle<IEvaluatorFloat> Scale
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorAcceleration()
		{
			EditorName = "Acceleration";
			EditorGroup = "Velocity";
			IsEnabled = true;
			WorldSpace = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
