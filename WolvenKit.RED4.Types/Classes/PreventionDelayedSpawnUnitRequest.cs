using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionDelayedSpawnUnitRequest : gameScriptableSystemRequest
	{
		private TweakDBID _recordID;
		private CUInt32 _preventionLevel;
		private WorldTransform _spawnTransform;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("preventionLevel")] 
		public CUInt32 PreventionLevel
		{
			get => GetProperty(ref _preventionLevel);
			set => SetProperty(ref _preventionLevel, value);
		}

		[Ordinal(2)] 
		[RED("spawnTransform")] 
		public WorldTransform SpawnTransform
		{
			get => GetProperty(ref _spawnTransform);
			set => SetProperty(ref _spawnTransform, value);
		}
	}
}
