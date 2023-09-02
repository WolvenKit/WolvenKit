using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionDelayedSpawnUnitRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("preventionLevel")] 
		public CUInt32 PreventionLevel
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("spawnTransform")] 
		public WorldTransform SpawnTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		public PreventionDelayedSpawnUnitRequest()
		{
			SpawnTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
