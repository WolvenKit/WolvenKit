using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerSpawnCircle : IParticleInitializer
	{
		[Ordinal(4)] 
		[RED("innerRadius")] 
		public CHandle<IEvaluatorFloat> InnerRadius
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("outerRadius")] 
		public CHandle<IEvaluatorFloat> OuterRadius
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("surfaceOnly")] 
		public CBool SurfaceOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("spawnToLocal")] 
		public CMatrix SpawnToLocal
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		public CParticleInitializerSpawnCircle()
		{
			EditorName = "Spawn circle";
			EditorGroup = "Deprecated";
			IsEnabled = true;
			WorldSpace = true;
			SpawnToLocal = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
