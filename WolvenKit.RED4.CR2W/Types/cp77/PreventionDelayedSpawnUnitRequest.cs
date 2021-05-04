using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDelayedSpawnUnitRequest : gameScriptableSystemRequest
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

		public PreventionDelayedSpawnUnitRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
