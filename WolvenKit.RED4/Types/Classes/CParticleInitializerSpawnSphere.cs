using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleInitializerSpawnSphere : IParticleInitializer
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
		[RED("spawnPositiveX")] 
		public CBool SpawnPositiveX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("spawnNegativeX")] 
		public CBool SpawnNegativeX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("spawnPositiveY")] 
		public CBool SpawnPositiveY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("spawnNegativeY")] 
		public CBool SpawnNegativeY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("spawnPositiveZ")] 
		public CBool SpawnPositiveZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("spawnNegativeZ")] 
		public CBool SpawnNegativeZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("velocity")] 
		public CBool Velocity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("forceScale")] 
		public CHandle<IEvaluatorFloat> ForceScale
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		public CParticleInitializerSpawnSphere()
		{
			EditorName = "Spawn sphere";
			EditorGroup = "Location";
			IsEnabled = true;
			SpawnPositiveX = true;
			SpawnNegativeX = true;
			SpawnPositiveY = true;
			SpawnNegativeY = true;
			SpawnPositiveZ = true;
			SpawnNegativeZ = true;
			WorldSpace = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
