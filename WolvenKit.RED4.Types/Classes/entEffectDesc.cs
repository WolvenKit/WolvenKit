using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEffectDesc : ISerializable
	{
		private CRUID _id;
		private CName _effectName;
		private CResourceAsyncReference<worldEffect> _effect;
		private worldCompiledEffectInfo _compiledEffectInfo;
		private CName _autoSpawnTag;
		private CBool _isAutoSpawn;
		private CUInt8 _randomWeight;

		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(2)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(3)] 
		[RED("compiledEffectInfo")] 
		public worldCompiledEffectInfo CompiledEffectInfo
		{
			get => GetProperty(ref _compiledEffectInfo);
			set => SetProperty(ref _compiledEffectInfo, value);
		}

		[Ordinal(4)] 
		[RED("autoSpawnTag")] 
		public CName AutoSpawnTag
		{
			get => GetProperty(ref _autoSpawnTag);
			set => SetProperty(ref _autoSpawnTag, value);
		}

		[Ordinal(5)] 
		[RED("isAutoSpawn")] 
		public CBool IsAutoSpawn
		{
			get => GetProperty(ref _isAutoSpawn);
			set => SetProperty(ref _isAutoSpawn, value);
		}

		[Ordinal(6)] 
		[RED("randomWeight")] 
		public CUInt8 RandomWeight
		{
			get => GetProperty(ref _randomWeight);
			set => SetProperty(ref _randomWeight, value);
		}
	}
}
