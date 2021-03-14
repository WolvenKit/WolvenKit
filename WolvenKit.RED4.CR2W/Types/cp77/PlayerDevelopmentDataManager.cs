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
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerDevSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevSystem
		{
			get
			{
				if (_playerDevSystem == null)
				{
					_playerDevSystem = (CHandle<PlayerDevelopmentSystem>) CR2WTypeManager.Create("handle:PlayerDevelopmentSystem", "playerDevSystem", cr2w, this);
				}
				return _playerDevSystem;
			}
			set
			{
				if (_playerDevSystem == value)
				{
					return;
				}
				_playerDevSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parentGameCtrl")] 
		public wCHandle<gameuiWidgetGameController> ParentGameCtrl
		{
			get
			{
				if (_parentGameCtrl == null)
				{
					_parentGameCtrl = (wCHandle<gameuiWidgetGameController>) CR2WTypeManager.Create("whandle:gameuiWidgetGameController", "parentGameCtrl", cr2w, this);
				}
				return _parentGameCtrl;
			}
			set
			{
				if (_parentGameCtrl == value)
				{
					return;
				}
				_parentGameCtrl = value;
				PropertySet(this);
			}
		}

		public PlayerDevelopmentDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
