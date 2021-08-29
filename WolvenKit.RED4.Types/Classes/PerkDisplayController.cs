using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkDisplayController : inkButtonController
	{
		private inkTextWidgetReference _levelText;
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _fluffText;
		private inkWidgetReference _requiredTrainerIcon;
		private inkTextWidgetReference _requiredPointsText;
		private CHandle<BasePerkDisplayData> _displayData;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CWeakHandle<PlayerDevelopmentData> _playerDevelopmentData;
		private CBool _recentlyPurchased;
		private CBool _holdStarted;
		private CBool _isTrait;
		private CBool _wasLocked;
		private CInt32 _index;
		private CHandle<inkanimProxy> _cool_in_proxy;
		private CHandle<inkanimProxy> _cool_out_proxy;

		[Ordinal(10)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(11)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(12)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get => GetProperty(ref _fluffText);
			set => SetProperty(ref _fluffText, value);
		}

		[Ordinal(13)] 
		[RED("requiredTrainerIcon")] 
		public inkWidgetReference RequiredTrainerIcon
		{
			get => GetProperty(ref _requiredTrainerIcon);
			set => SetProperty(ref _requiredTrainerIcon, value);
		}

		[Ordinal(14)] 
		[RED("requiredPointsText")] 
		public inkTextWidgetReference RequiredPointsText
		{
			get => GetProperty(ref _requiredPointsText);
			set => SetProperty(ref _requiredPointsText, value);
		}

		[Ordinal(15)] 
		[RED("displayData")] 
		public CHandle<BasePerkDisplayData> DisplayData
		{
			get => GetProperty(ref _displayData);
			set => SetProperty(ref _displayData, value);
		}

		[Ordinal(16)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(17)] 
		[RED("playerDevelopmentData")] 
		public CWeakHandle<PlayerDevelopmentData> PlayerDevelopmentData
		{
			get => GetProperty(ref _playerDevelopmentData);
			set => SetProperty(ref _playerDevelopmentData, value);
		}

		[Ordinal(18)] 
		[RED("recentlyPurchased")] 
		public CBool RecentlyPurchased
		{
			get => GetProperty(ref _recentlyPurchased);
			set => SetProperty(ref _recentlyPurchased, value);
		}

		[Ordinal(19)] 
		[RED("holdStarted")] 
		public CBool HoldStarted
		{
			get => GetProperty(ref _holdStarted);
			set => SetProperty(ref _holdStarted, value);
		}

		[Ordinal(20)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get => GetProperty(ref _isTrait);
			set => SetProperty(ref _isTrait, value);
		}

		[Ordinal(21)] 
		[RED("wasLocked")] 
		public CBool WasLocked
		{
			get => GetProperty(ref _wasLocked);
			set => SetProperty(ref _wasLocked, value);
		}

		[Ordinal(22)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(23)] 
		[RED("cool_in_proxy")] 
		public CHandle<inkanimProxy> Cool_in_proxy
		{
			get => GetProperty(ref _cool_in_proxy);
			set => SetProperty(ref _cool_in_proxy, value);
		}

		[Ordinal(24)] 
		[RED("cool_out_proxy")] 
		public CHandle<inkanimProxy> Cool_out_proxy
		{
			get => GetProperty(ref _cool_out_proxy);
			set => SetProperty(ref _cool_out_proxy, value);
		}
	}
}
