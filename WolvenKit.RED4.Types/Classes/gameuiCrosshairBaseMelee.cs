using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCrosshairBaseMelee : gameuiCrosshairBaseGameController
	{
		private CHandle<redCallbackObject> _meleeStateBlackboardId;
		private CWeakHandle<gameIBlackboard> _playerSMBB;

		[Ordinal(18)] 
		[RED("meleeStateBlackboardId")] 
		public CHandle<redCallbackObject> MeleeStateBlackboardId
		{
			get => GetProperty(ref _meleeStateBlackboardId);
			set => SetProperty(ref _meleeStateBlackboardId, value);
		}

		[Ordinal(19)] 
		[RED("playerSMBB")] 
		public CWeakHandle<gameIBlackboard> PlayerSMBB
		{
			get => GetProperty(ref _playerSMBB);
			set => SetProperty(ref _playerSMBB, value);
		}
	}
}
