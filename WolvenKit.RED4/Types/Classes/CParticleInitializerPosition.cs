using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerPosition : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("position")] 
		public CHandle<IEvaluatorVector> Position
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(6)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleInitializerPosition()
		{
			EditorName = "Initial position";
			EditorGroup = "Location";
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
