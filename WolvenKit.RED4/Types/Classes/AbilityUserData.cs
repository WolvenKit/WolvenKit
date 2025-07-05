using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AbilityUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("abilityID")] 
		public TweakDBID AbilityID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("locKeyName")] 
		public CName LocKeyName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("asyncSpawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>();
			set => SetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>(value);
		}

		public AbilityUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
