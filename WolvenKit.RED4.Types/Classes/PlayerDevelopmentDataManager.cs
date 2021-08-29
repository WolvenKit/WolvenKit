using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerDevelopmentDataManager : IScriptable
	{
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<PlayerDevelopmentSystem> _playerDevSystem;
		private CWeakHandle<gameuiWidgetGameController> _parentGameCtrl;

		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("playerDevSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevSystem
		{
			get => GetProperty(ref _playerDevSystem);
			set => SetProperty(ref _playerDevSystem, value);
		}

		[Ordinal(2)] 
		[RED("parentGameCtrl")] 
		public CWeakHandle<gameuiWidgetGameController> ParentGameCtrl
		{
			get => GetProperty(ref _parentGameCtrl);
			set => SetProperty(ref _parentGameCtrl, value);
		}
	}
}
