using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CompanionHealthBarGameController : gameuiHUDGameController
	{
		private inkWidgetReference _healthbar;
		private CWeakHandle<inkWidget> _root;
		private CHandle<redCallbackObject> _flatheadListener;
		private CBool _isActive;
		private CFloat _maxHealth;
		private CHandle<CompanionHealthStatListener> _healthStatListener;
		private CWeakHandle<gameIBlackboard> _companionBlackboard;
		private ScriptGameInstance _gameInstance;
		private CHandle<gameStatPoolsSystem> _statPoolsSystem;

		[Ordinal(9)] 
		[RED("healthbar")] 
		public inkWidgetReference Healthbar
		{
			get => GetProperty(ref _healthbar);
			set => SetProperty(ref _healthbar, value);
		}

		[Ordinal(10)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(11)] 
		[RED("flatheadListener")] 
		public CHandle<redCallbackObject> FlatheadListener
		{
			get => GetProperty(ref _flatheadListener);
			set => SetProperty(ref _flatheadListener, value);
		}

		[Ordinal(12)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(13)] 
		[RED("maxHealth")] 
		public CFloat MaxHealth
		{
			get => GetProperty(ref _maxHealth);
			set => SetProperty(ref _maxHealth, value);
		}

		[Ordinal(14)] 
		[RED("healthStatListener")] 
		public CHandle<CompanionHealthStatListener> HealthStatListener
		{
			get => GetProperty(ref _healthStatListener);
			set => SetProperty(ref _healthStatListener, value);
		}

		[Ordinal(15)] 
		[RED("companionBlackboard")] 
		public CWeakHandle<gameIBlackboard> CompanionBlackboard
		{
			get => GetProperty(ref _companionBlackboard);
			set => SetProperty(ref _companionBlackboard, value);
		}

		[Ordinal(16)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(17)] 
		[RED("statPoolsSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolsSystem
		{
			get => GetProperty(ref _statPoolsSystem);
			set => SetProperty(ref _statPoolsSystem, value);
		}
	}
}
