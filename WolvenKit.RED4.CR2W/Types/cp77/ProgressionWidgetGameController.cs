using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressionWidgetGameController : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private CHandle<PlayerDevelopmentSystem> _playerDevelopmentSystem;
		private CEnum<gamePSMCombat> _combatModePSM;
		private CHandle<redCallbackObject> _combatModeListener;
		private wCHandle<gameObject> _playerObject;
		private ScriptGameInstance _gameInstance;

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetProperty(ref _playerDevelopmentSystem);
			set => SetProperty(ref _playerDevelopmentSystem, value);
		}

		[Ordinal(4)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get => GetProperty(ref _combatModePSM);
			set => SetProperty(ref _combatModePSM, value);
		}

		[Ordinal(5)] 
		[RED("combatModeListener")] 
		public CHandle<redCallbackObject> CombatModeListener
		{
			get => GetProperty(ref _combatModeListener);
			set => SetProperty(ref _combatModeListener, value);
		}

		[Ordinal(6)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(7)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public ProgressionWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
