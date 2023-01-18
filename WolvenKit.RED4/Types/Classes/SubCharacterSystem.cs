using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SubCharacterSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("uniqueSubCharacters")] 
		public CArray<SSubCharacter> UniqueSubCharacters
		{
			get => GetPropertyValue<CArray<SSubCharacter>>();
			set => SetPropertyValue<CArray<SSubCharacter>>(value);
		}

		[Ordinal(1)] 
		[RED("scriptSpawnedFlathead")] 
		public CBool ScriptSpawnedFlathead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isDespawningFlathead")] 
		public CBool IsDespawningFlathead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SubCharacterSystem()
		{
			UniqueSubCharacters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
