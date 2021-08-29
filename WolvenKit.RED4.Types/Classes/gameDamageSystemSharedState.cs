using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDamageSystemSharedState : gameIGameSystemReplicatedState
	{
		private CArray<CHandle<gamedamageServerHitData>> _hitHistory;
		private CArray<CHandle<gamedamageServerKillData>> _killHistory;

		[Ordinal(0)] 
		[RED("hitHistory")] 
		public CArray<CHandle<gamedamageServerHitData>> HitHistory
		{
			get => GetProperty(ref _hitHistory);
			set => SetProperty(ref _hitHistory, value);
		}

		[Ordinal(1)] 
		[RED("killHistory")] 
		public CArray<CHandle<gamedamageServerKillData>> KillHistory
		{
			get => GetProperty(ref _killHistory);
			set => SetProperty(ref _killHistory, value);
		}
	}
}
