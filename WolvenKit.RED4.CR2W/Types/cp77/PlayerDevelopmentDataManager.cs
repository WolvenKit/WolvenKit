using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentDataManager : IScriptable
	{
		private wCHandle<PlayerPuppet> _player;
		private CHandle<PlayerDevelopmentSystem> _playerDevSystem;
		private wCHandle<gameuiWidgetGameController> _parentGameCtrl;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
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
		public wCHandle<gameuiWidgetGameController> ParentGameCtrl
		{
			get => GetProperty(ref _parentGameCtrl);
			set => SetProperty(ref _parentGameCtrl, value);
		}

		public PlayerDevelopmentDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
