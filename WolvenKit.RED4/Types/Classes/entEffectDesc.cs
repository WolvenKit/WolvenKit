using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEffectDesc : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(3)] 
		[RED("compiledEffectInfo")] 
		public worldCompiledEffectInfo CompiledEffectInfo
		{
			get => GetPropertyValue<worldCompiledEffectInfo>();
			set => SetPropertyValue<worldCompiledEffectInfo>(value);
		}

		[Ordinal(4)] 
		[RED("autoSpawnTag")] 
		public CName AutoSpawnTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("isAutoSpawn")] 
		public CBool IsAutoSpawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("randomWeight")] 
		public CUInt8 RandomWeight
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public entEffectDesc()
		{
			CompiledEffectInfo = new() { PlacementTags = new(), ComponentNames = new(), RelativePositions = new(), RelativeRotations = new(), PlacementInfos = new(), EventsSortedByRUID = new() };
			AutoSpawnTag = "_autospawn";
			RandomWeight = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
