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
			get => GetProperty(ref _gameplaySettingsListener);
			set => SetProperty(ref _gameplaySettingsListener, value);
		}

		[Ordinal(1)] 
		[RED("wasEverJohnny")] 
		public CBool WasEverJohnny
		{
			get => GetProperty(ref _wasEverJohnny);
			set => SetProperty(ref _wasEverJohnny, value);
		}

		public GameplaySettingsSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
