using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class dbgSpawner : gameObject
	{
		[Ordinal(36)] 
		[RED("objectRecordId")] 
		public TweakDBID ObjectRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(37)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get => GetPropertyValue<CEnum<gameAlwaysSpawnedState>>();
			set => SetPropertyValue<CEnum<gameAlwaysSpawnedState>>(value);
		}

		public dbgSpawner()
		{
			Appearance = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
