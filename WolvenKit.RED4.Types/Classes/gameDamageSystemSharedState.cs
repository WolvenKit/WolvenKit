using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDamageSystemSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("hitHistory")] 
		public CArray<CHandle<gamedamageServerHitData>> HitHistory
		{
			get => GetPropertyValue<CArray<CHandle<gamedamageServerHitData>>>();
			set => SetPropertyValue<CArray<CHandle<gamedamageServerHitData>>>(value);
		}

		[Ordinal(1)] 
		[RED("killHistory")] 
		public CArray<CHandle<gamedamageServerKillData>> KillHistory
		{
			get => GetPropertyValue<CArray<CHandle<gamedamageServerKillData>>>();
			set => SetPropertyValue<CArray<CHandle<gamedamageServerKillData>>>(value);
		}

		public gameDamageSystemSharedState()
		{
			HitHistory = new();
			KillHistory = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
