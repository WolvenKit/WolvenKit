using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingSkillWidget : gameuiWidgetGameController
	{
		private inkTextWidgetReference _amountText;
		private inkWidgetReference _expFill;
		private inkWidgetReference _perkHolder;
		private inkWidgetReference _levelUpAnimation;
		private inkWidgetReference _expAnimation;
		private inkTextWidgetReference _nextLevelText;
		private inkTextWidgetReference _expPointText1;
		private inkTextWidgetReference _expPointText2;
		private CHandle<gameIBlackboard> _levelUpBlackboard;
		private CUInt32 _playerLevelUpListener;
		private CBool _isLevelUp;
		private CInt32 _currentExp;

		[Ordinal(2)] 
		[RED("amountText")] 
		public inkTextWidgetReference AmountText
		{
			get
			{
				if (_amountText == null)
				{
					_amountText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "amountText", cr2w, this);
				}
				return _amountText;
			}
			set
			{
				if (_amountText == value)
				{
					return;
				}
				_amountText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("expFill")] 
		public inkWidgetReference ExpFill
		{
			get
			{
				if (_expFill == null)
				{
					_expFill = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "expFill", cr2w, this);
				}
				return _expFill;
			}
			set
			{
				if (_expFill == value)
				{
					return;
				}
				_expFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("perkHolder")] 
		public inkWidgetReference PerkHolder
		{
			get
			{
				if (_perkHolder == null)
				{
					_perkHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "perkHolder", cr2w, this);
				}
				return _perkHolder;
			}
			set
			{
				if (_perkHolder == value)
				{
					return;
				}
				_perkHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("levelUpAnimation")] 
		public inkWidgetReference LevelUpAnimation
		{
			get
			{
				if (_levelUpAnimation == null)
				{
					_levelUpAnimation = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelUpAnimation", cr2w, this);
				}
				return _levelUpAnimation;
			}
			set
			{
				if (_levelUpAnimation == value)
				{
					return;
				}
				_levelUpAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("expAnimation")] 
		public inkWidgetReference ExpAnimation
		{
			get
			{
				if (_expAnimation == null)
				{
					_expAnimation = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "expAnimation", cr2w, this);
				}
				return _expAnimation;
			}
			set
			{
				if (_expAnimation == value)
				{
					return;
				}
				_expAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("nextLevelText")] 
		public inkTextWidgetReference NextLevelText
		{
			get
			{
				if (_nextLevelText == null)
				{
					_nextLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nextLevelText", cr2w, this);
				}
				return _nextLevelText;
			}
			set
			{
				if (_nextLevelText == value)
				{
					return;
				}
				_nextLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("expPointText1")] 
		public inkTextWidgetReference ExpPointText1
		{
			get
			{
				if (_expPointText1 == null)
				{
					_expPointText1 = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "expPointText1", cr2w, this);
				}
				return _expPointText1;
			}
			set
			{
				if (_expPointText1 == value)
				{
					return;
				}
				_expPointText1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("expPointText2")] 
		public inkTextWidgetReference ExpPointText2
		{
			get
			{
				if (_expPointText2 == null)
				{
					_expPointText2 = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "expPointText2", cr2w, this);
				}
				return _expPointText2;
			}
			set
			{
				if (_expPointText2 == value)
				{
					return;
				}
				_expPointText2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("levelUpBlackboard")] 
		public CHandle<gameIBlackboard> LevelUpBlackboard
		{
			get
			{
				if (_levelUpBlackboard == null)
				{
					_levelUpBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "levelUpBlackboard", cr2w, this);
				}
				return _levelUpBlackboard;
			}
			set
			{
				if (_levelUpBlackboard == value)
				{
					return;
				}
				_levelUpBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("playerLevelUpListener")] 
		public CUInt32 PlayerLevelUpListener
		{
			get
			{
				if (_playerLevelUpListener == null)
				{
					_playerLevelUpListener = (CUInt32) CR2WTypeManager.Create("Uint32", "playerLevelUpListener", cr2w, this);
				}
				return _playerLevelUpListener;
			}
			set
			{
				if (_playerLevelUpListener == value)
				{
					return;
				}
				_playerLevelUpListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isLevelUp")] 
		public CBool IsLevelUp
		{
			get
			{
				if (_isLevelUp == null)
				{
					_isLevelUp = (CBool) CR2WTypeManager.Create("Bool", "isLevelUp", cr2w, this);
				}
				return _isLevelUp;
			}
			set
			{
				if (_isLevelUp == value)
				{
					return;
				}
				_isLevelUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("currentExp")] 
		public CInt32 CurrentExp
		{
			get
			{
				if (_currentExp == null)
				{
					_currentExp = (CInt32) CR2WTypeManager.Create("Int32", "currentExp", cr2w, this);
				}
				return _currentExp;
			}
			set
			{
				if (_currentExp == value)
				{
					return;
				}
				_currentExp = value;
				PropertySet(this);
			}
		}

		public CraftingSkillWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
