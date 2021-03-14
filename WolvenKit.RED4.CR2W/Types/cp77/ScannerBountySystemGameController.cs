using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerBountySystemGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _moneyReward;
		private inkWidgetReference _moneyRewardRow;
		private inkTextWidgetReference _streetCredReward;
		private inkWidgetReference _streetCredRewardRow;
		private inkTextWidgetReference _transgressions;
		private inkWidgetReference _transgressionsWidget;
		private inkCompoundWidgetReference _rewardPanel;
		private inkRectangleWidgetReference _mugShot;
		private inkTextWidgetReference _wanted;
		private inkTextWidgetReference _notFound;
		private inkTextWidgetReference _deadNotice;
		private inkWidgetReference _crossedOut;
		private CArray<inkWidgetReference> _starsWidget;
		private CUInt32 _bountyCallbackID;
		private CUInt32 _healthCallbackID;
		private CUInt32 _objectCallbackID;
		private CBool _isValidBounty;
		private CBool _isAlive;
		private CEnum<ScannerObjectType> _objectType;
		private CHandle<inkanimProxy> _showScanBountyAnimProxy;

		[Ordinal(5)] 
		[RED("moneyReward")] 
		public inkTextWidgetReference MoneyReward
		{
			get
			{
				if (_moneyReward == null)
				{
					_moneyReward = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "moneyReward", cr2w, this);
				}
				return _moneyReward;
			}
			set
			{
				if (_moneyReward == value)
				{
					return;
				}
				_moneyReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("moneyRewardRow")] 
		public inkWidgetReference MoneyRewardRow
		{
			get
			{
				if (_moneyRewardRow == null)
				{
					_moneyRewardRow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "moneyRewardRow", cr2w, this);
				}
				return _moneyRewardRow;
			}
			set
			{
				if (_moneyRewardRow == value)
				{
					return;
				}
				_moneyRewardRow = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("streetCredReward")] 
		public inkTextWidgetReference StreetCredReward
		{
			get
			{
				if (_streetCredReward == null)
				{
					_streetCredReward = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "streetCredReward", cr2w, this);
				}
				return _streetCredReward;
			}
			set
			{
				if (_streetCredReward == value)
				{
					return;
				}
				_streetCredReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("streetCredRewardRow")] 
		public inkWidgetReference StreetCredRewardRow
		{
			get
			{
				if (_streetCredRewardRow == null)
				{
					_streetCredRewardRow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetCredRewardRow", cr2w, this);
				}
				return _streetCredRewardRow;
			}
			set
			{
				if (_streetCredRewardRow == value)
				{
					return;
				}
				_streetCredRewardRow = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("transgressions")] 
		public inkTextWidgetReference Transgressions
		{
			get
			{
				if (_transgressions == null)
				{
					_transgressions = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "transgressions", cr2w, this);
				}
				return _transgressions;
			}
			set
			{
				if (_transgressions == value)
				{
					return;
				}
				_transgressions = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("transgressionsWidget")] 
		public inkWidgetReference TransgressionsWidget
		{
			get
			{
				if (_transgressionsWidget == null)
				{
					_transgressionsWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "transgressionsWidget", cr2w, this);
				}
				return _transgressionsWidget;
			}
			set
			{
				if (_transgressionsWidget == value)
				{
					return;
				}
				_transgressionsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rewardPanel")] 
		public inkCompoundWidgetReference RewardPanel
		{
			get
			{
				if (_rewardPanel == null)
				{
					_rewardPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "rewardPanel", cr2w, this);
				}
				return _rewardPanel;
			}
			set
			{
				if (_rewardPanel == value)
				{
					return;
				}
				_rewardPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("mugShot")] 
		public inkRectangleWidgetReference MugShot
		{
			get
			{
				if (_mugShot == null)
				{
					_mugShot = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "mugShot", cr2w, this);
				}
				return _mugShot;
			}
			set
			{
				if (_mugShot == value)
				{
					return;
				}
				_mugShot = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("wanted")] 
		public inkTextWidgetReference Wanted
		{
			get
			{
				if (_wanted == null)
				{
					_wanted = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "wanted", cr2w, this);
				}
				return _wanted;
			}
			set
			{
				if (_wanted == value)
				{
					return;
				}
				_wanted = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("notFound")] 
		public inkTextWidgetReference NotFound
		{
			get
			{
				if (_notFound == null)
				{
					_notFound = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "notFound", cr2w, this);
				}
				return _notFound;
			}
			set
			{
				if (_notFound == value)
				{
					return;
				}
				_notFound = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("deadNotice")] 
		public inkTextWidgetReference DeadNotice
		{
			get
			{
				if (_deadNotice == null)
				{
					_deadNotice = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "deadNotice", cr2w, this);
				}
				return _deadNotice;
			}
			set
			{
				if (_deadNotice == value)
				{
					return;
				}
				_deadNotice = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("crossedOut")] 
		public inkWidgetReference CrossedOut
		{
			get
			{
				if (_crossedOut == null)
				{
					_crossedOut = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "crossedOut", cr2w, this);
				}
				return _crossedOut;
			}
			set
			{
				if (_crossedOut == value)
				{
					return;
				}
				_crossedOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("starsWidget")] 
		public CArray<inkWidgetReference> StarsWidget
		{
			get
			{
				if (_starsWidget == null)
				{
					_starsWidget = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "starsWidget", cr2w, this);
				}
				return _starsWidget;
			}
			set
			{
				if (_starsWidget == value)
				{
					return;
				}
				_starsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bountyCallbackID")] 
		public CUInt32 BountyCallbackID
		{
			get
			{
				if (_bountyCallbackID == null)
				{
					_bountyCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "bountyCallbackID", cr2w, this);
				}
				return _bountyCallbackID;
			}
			set
			{
				if (_bountyCallbackID == value)
				{
					return;
				}
				_bountyCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("healthCallbackID")] 
		public CUInt32 HealthCallbackID
		{
			get
			{
				if (_healthCallbackID == null)
				{
					_healthCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "healthCallbackID", cr2w, this);
				}
				return _healthCallbackID;
			}
			set
			{
				if (_healthCallbackID == value)
				{
					return;
				}
				_healthCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("objectCallbackID")] 
		public CUInt32 ObjectCallbackID
		{
			get
			{
				if (_objectCallbackID == null)
				{
					_objectCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "objectCallbackID", cr2w, this);
				}
				return _objectCallbackID;
			}
			set
			{
				if (_objectCallbackID == value)
				{
					return;
				}
				_objectCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("isValidBounty")] 
		public CBool IsValidBounty
		{
			get
			{
				if (_isValidBounty == null)
				{
					_isValidBounty = (CBool) CR2WTypeManager.Create("Bool", "isValidBounty", cr2w, this);
				}
				return _isValidBounty;
			}
			set
			{
				if (_isValidBounty == value)
				{
					return;
				}
				_isValidBounty = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get
			{
				if (_isAlive == null)
				{
					_isAlive = (CBool) CR2WTypeManager.Create("Bool", "isAlive", cr2w, this);
				}
				return _isAlive;
			}
			set
			{
				if (_isAlive == value)
				{
					return;
				}
				_isAlive = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("objectType")] 
		public CEnum<ScannerObjectType> ObjectType
		{
			get
			{
				if (_objectType == null)
				{
					_objectType = (CEnum<ScannerObjectType>) CR2WTypeManager.Create("ScannerObjectType", "objectType", cr2w, this);
				}
				return _objectType;
			}
			set
			{
				if (_objectType == value)
				{
					return;
				}
				_objectType = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("showScanBountyAnimProxy")] 
		public CHandle<inkanimProxy> ShowScanBountyAnimProxy
		{
			get
			{
				if (_showScanBountyAnimProxy == null)
				{
					_showScanBountyAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showScanBountyAnimProxy", cr2w, this);
				}
				return _showScanBountyAnimProxy;
			}
			set
			{
				if (_showScanBountyAnimProxy == value)
				{
					return;
				}
				_showScanBountyAnimProxy = value;
				PropertySet(this);
			}
		}

		public ScannerBountySystemGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
