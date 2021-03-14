using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsSystem : gameScriptableSystem
	{
		private CHandle<GameplaySettingsListener> _gameplaySettingsListener;
		private CBool _wasEverJohnny;

		[Ordinal(0)] 
		[RED("gameplaySettingsListener")] 
		public CHandle<GameplaySettingsListener> GameplaySettingsListener
		{
			get
			{
				if (_gameplaySettingsListener == null)
				{
					_gameplaySettingsListener = (CHandle<GameplaySettingsListener>) CR2WTypeManager.Create("handle:GameplaySettingsListener", "gameplaySettingsListener", cr2w, this);
				}
				return _gameplaySettingsListener;
			}
			set
			{
				if (_gameplaySettingsListener == value)
				{
					return;
				}
				_gameplaySettingsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wasEverJohnny")] 
		public CBool WasEverJohnny
		{
			get
			{
				if (_wasEverJohnny == null)
				{
					_wasEverJohnny = (CBool) CR2WTypeManager.Create("Bool", "wasEverJohnny", cr2w, this);
				}
				return _wasEverJohnny;
			}
			set
			{
				if (_wasEverJohnny == value)
				{
					return;
				}
				_wasEverJohnny = value;
				PropertySet(this);
			}
		}

		public GameplaySettingsSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
