using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerSpawnBox : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("extents")] 
		public CHandle<IEvaluatorVector> Extents
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("surfaceOnly")] 
		public CBool SurfaceOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleInitializerSpawnBox()
		{
			EditorName = "Spawn box";
			EditorGroup = "Location";
			IsEnabled = true;
			WorldSpace = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
