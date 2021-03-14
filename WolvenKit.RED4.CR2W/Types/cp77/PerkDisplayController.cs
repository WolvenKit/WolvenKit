using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayController : inkButtonController
	{
		private inkTextWidgetReference _levelText;
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _fluffText;
		private inkWidgetReference _requiredTrainerIcon;
		private inkTextWidgetReference _requiredPointsText;
		private CHandle<BasePerkDisplayData> _displayData;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private wCHandle<PlayerDevelopmentData> _playerDevelopmentData;
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
			get
			{
				if (_levelText == null)
				{
					_levelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelText", cr2w, this);
				}
				return _levelText;
			}
			set
			{
				if (_levelText == value)
				{
					return;
				}
				_levelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get
			{
				if (_fluffText == null)
				{
					_fluffText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffText", cr2w, this);
				}
				return _fluffText;
			}
			set
			{
				if (_fluffText == value)
				{
					return;
				}
				_fluffText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("requiredTrainerIcon")] 
		public inkWidgetReference RequiredTrainerIcon
		{
			get
			{
				if (_requiredTrainerIcon == null)
				{
					_requiredTrainerIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "requiredTrainerIcon", cr2w, this);
				}
				return _requiredTrainerIcon;
			}
			set
			{
				if (_requiredTrainerIcon == value)
				{
					return;
				}
				_requiredTrainerIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("requiredPointsText")] 
		public inkTextWidgetReference RequiredPointsText
		{
			get
			{
				if (_requiredPointsText == null)
				{
					_requiredPointsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "requiredPointsText", cr2w, this);
				}
				return _requiredPointsText;
			}
			set
			{
				if (_requiredPointsText == value)
				{
					return;
				}
				_requiredPointsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("displayData")] 
		public CHandle<BasePerkDisplayData> DisplayData
		{
			get
			{
				if (_displayData == null)
				{
					_displayData = (CHandle<BasePerkDisplayData>) CR2WTypeManager.Create("handle:BasePerkDisplayData", "displayData", cr2w, this);
				}
				return _displayData;
			}
			set
			{
				if (_displayData == value)
				{
					return;
				}
				_displayData = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<PlayerDevelopmentDataManager>) CR2WTypeManager.Create("handle:PlayerDevelopmentDataManager", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("playerDevelopmentData")] 
		public wCHandle<PlayerDevelopmentData> PlayerDevelopmentData
		{
			get
			{
				if (_playerDevelopmentData == null)
				{
					_playerDevelopmentData = (wCHandle<PlayerDevelopmentData>) CR2WTypeManager.Create("whandle:PlayerDevelopmentData", "playerDevelopmentData", cr2w, this);
				}
				return _playerDevelopmentData;
			}
			set
			{
				if (_playerDevelopmentData == value)
				{
					return;
				}
				_playerDevelopmentData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("recentlyPurchased")] 
		public CBool RecentlyPurchased
		{
			get
			{
				if (_recentlyPurchased == null)
				{
					_recentlyPurchased = (CBool) CR2WTypeManager.Create("Bool", "recentlyPurchased", cr2w, this);
				}
				return _recentlyPurchased;
			}
			set
			{
				if (_recentlyPurchased == value)
				{
					return;
				}
				_recentlyPurchased = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("holdStarted")] 
		public CBool HoldStarted
		{
			get
			{
				if (_holdStarted == null)
				{
					_holdStarted = (CBool) CR2WTypeManager.Create("Bool", "holdStarted", cr2w, this);
				}
				return _holdStarted;
			}
			set
			{
				if (_holdStarted == value)
				{
					return;
				}
				_holdStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get
			{
				if (_isTrait == null)
				{
					_isTrait = (CBool) CR2WTypeManager.Create("Bool", "isTrait", cr2w, this);
				}
				return _isTrait;
			}
			set
			{
				if (_isTrait == value)
				{
					return;
				}
				_isTrait = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("wasLocked")] 
		public CBool WasLocked
		{
			get
			{
				if (_wasLocked == null)
				{
					_wasLocked = (CBool) CR2WTypeManager.Create("Bool", "wasLocked", cr2w, this);
				}
				return _wasLocked;
			}
			set
			{
				if (_wasLocked == value)
				{
					return;
				}
				_wasLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("cool_in_proxy")] 
		public CHandle<inkanimProxy> Cool_in_proxy
		{
			get
			{
				if (_cool_in_proxy == null)
				{
					_cool_in_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "cool_in_proxy", cr2w, this);
				}
				return _cool_in_proxy;
			}
			set
			{
				if (_cool_in_proxy == value)
				{
					return;
				}
				_cool_in_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("cool_out_proxy")] 
		public CHandle<inkanimProxy> Cool_out_proxy
		{
			get
			{
				if (_cool_out_proxy == null)
				{
					_cool_out_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "cool_out_proxy", cr2w, this);
				}
				return _cool_out_proxy;
			}
			set
			{
				if (_cool_out_proxy == value)
				{
					return;
				}
				_cool_out_proxy = value;
				PropertySet(this);
			}
		}

		public PerkDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
