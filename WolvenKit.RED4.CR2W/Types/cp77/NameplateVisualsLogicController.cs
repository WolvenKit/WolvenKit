using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateVisualsLogicController : inkWidgetLogicController
	{
		private wCHandle<inkCompoundWidget> _rootWidget;
		private inkWidgetReference _bigIconMain;
		private inkTextWidgetReference _bigLevelText;
		private inkTextWidgetReference _nameTextMain;
		private inkImageWidgetReference _bigIconArt;
		private inkWidgetReference _preventionIcon;
		private inkImageWidgetReference _levelContainer;
		private inkWidgetReference _nameFrame;
		private inkWidgetReference _healthbarWidget;
		private inkWidgetReference _healthBarFull;
		private inkWidgetReference _healthBarFrame;
		private inkWidgetReference _taggedIcon;
		private inkWidgetReference _iconBG;
		private inkWidgetReference _civilianIcon;
		private inkCompoundWidgetReference _stealthMappinSlot;
		private inkCompoundWidgetReference _iconTextWrapper;
		private inkWidgetReference _container;
		private inkCompoundWidgetReference _levelcontainerAndText;
		private inkCompoundWidgetReference _rareStars;
		private inkCompoundWidgetReference _eliteStars;
		private inkImageWidgetReference _hardEnemy;
		private inkWidgetReference _hardEnemyWrapper;
		private inkWidgetReference _damagePreviewWrapper;
		private inkWidgetReference _damagePreviewWidget;
		private inkWidgetReference _damagePreviewArrow;
		private inkHorizontalPanelWidgetReference _buffsList;
		private CArray<wCHandle<inkWidget>> _buffWidgets;
		private wCHandle<gameObject> _cachedPuppet;
		private gameuiNPCNextToTheCrosshair _cachedIncomingData;
		private CBool _isOfficer;
		private CBool _isBoss;
		private CBool _isElite;
		private CBool _isRare;
		private CBool _isPrevention;
		private CBool _canCallReinforcements;
		private CBool _isCivilian;
		private CBool _isBurning;
		private CBool _isPoisoned;
		private CColor _bossColor;
		private CBool _npcDefeated;
		private CBool _isStealthMappinVisible;
		private CEnum<gamePSMZones> _playerZone;
		private wCHandle<NameplateBarLogicController> _healthController;
		private CBool _hasCenterIcon;
		private inkWidgetReference _animatingObject;
		private CBool _isAnimating;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CHandle<inkanimProxy> _preventionAnimProxy;
		private CHandle<inkanimProxy> _damagePreviewAnimProxy;
		private CBool _isQuestTarget;
		private CBool _forceHide;
		private CBool _isHardEnemy;
		private CBool _npcIsAggressive;
		private CBool _playerAimingDownSights;
		private CBool _playerInCombat;
		private CBool _playerInStealth;
		private CBool _healthNotFull;
		private CBool _healthbarVisible;
		private CBool _levelContainerShouldBeVisible;
		private CInt32 _currentHealth;
		private CInt32 _maximumHealth;
		private CInt32 _currentDamagePreviewValue;

		[Ordinal(1)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bigIconMain")] 
		public inkWidgetReference BigIconMain
		{
			get
			{
				if (_bigIconMain == null)
				{
					_bigIconMain = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bigIconMain", cr2w, this);
				}
				return _bigIconMain;
			}
			set
			{
				if (_bigIconMain == value)
				{
					return;
				}
				_bigIconMain = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bigLevelText")] 
		public inkTextWidgetReference BigLevelText
		{
			get
			{
				if (_bigLevelText == null)
				{
					_bigLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "bigLevelText", cr2w, this);
				}
				return _bigLevelText;
			}
			set
			{
				if (_bigLevelText == value)
				{
					return;
				}
				_bigLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nameTextMain")] 
		public inkTextWidgetReference NameTextMain
		{
			get
			{
				if (_nameTextMain == null)
				{
					_nameTextMain = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nameTextMain", cr2w, this);
				}
				return _nameTextMain;
			}
			set
			{
				if (_nameTextMain == value)
				{
					return;
				}
				_nameTextMain = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bigIconArt")] 
		public inkImageWidgetReference BigIconArt
		{
			get
			{
				if (_bigIconArt == null)
				{
					_bigIconArt = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "bigIconArt", cr2w, this);
				}
				return _bigIconArt;
			}
			set
			{
				if (_bigIconArt == value)
				{
					return;
				}
				_bigIconArt = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("preventionIcon")] 
		public inkWidgetReference PreventionIcon
		{
			get
			{
				if (_preventionIcon == null)
				{
					_preventionIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "preventionIcon", cr2w, this);
				}
				return _preventionIcon;
			}
			set
			{
				if (_preventionIcon == value)
				{
					return;
				}
				_preventionIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("levelContainer")] 
		public inkImageWidgetReference LevelContainer
		{
			get
			{
				if (_levelContainer == null)
				{
					_levelContainer = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "levelContainer", cr2w, this);
				}
				return _levelContainer;
			}
			set
			{
				if (_levelContainer == value)
				{
					return;
				}
				_levelContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("nameFrame")] 
		public inkWidgetReference NameFrame
		{
			get
			{
				if (_nameFrame == null)
				{
					_nameFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nameFrame", cr2w, this);
				}
				return _nameFrame;
			}
			set
			{
				if (_nameFrame == value)
				{
					return;
				}
				_nameFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("healthbarWidget")] 
		public inkWidgetReference HealthbarWidget
		{
			get
			{
				if (_healthbarWidget == null)
				{
					_healthbarWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "healthbarWidget", cr2w, this);
				}
				return _healthbarWidget;
			}
			set
			{
				if (_healthbarWidget == value)
				{
					return;
				}
				_healthbarWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("healthBarFull")] 
		public inkWidgetReference HealthBarFull
		{
			get
			{
				if (_healthBarFull == null)
				{
					_healthBarFull = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "healthBarFull", cr2w, this);
				}
				return _healthBarFull;
			}
			set
			{
				if (_healthBarFull == value)
				{
					return;
				}
				_healthBarFull = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("healthBarFrame")] 
		public inkWidgetReference HealthBarFrame
		{
			get
			{
				if (_healthBarFrame == null)
				{
					_healthBarFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "healthBarFrame", cr2w, this);
				}
				return _healthBarFrame;
			}
			set
			{
				if (_healthBarFrame == value)
				{
					return;
				}
				_healthBarFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("taggedIcon")] 
		public inkWidgetReference TaggedIcon
		{
			get
			{
				if (_taggedIcon == null)
				{
					_taggedIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "taggedIcon", cr2w, this);
				}
				return _taggedIcon;
			}
			set
			{
				if (_taggedIcon == value)
				{
					return;
				}
				_taggedIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("iconBG")] 
		public inkWidgetReference IconBG
		{
			get
			{
				if (_iconBG == null)
				{
					_iconBG = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconBG", cr2w, this);
				}
				return _iconBG;
			}
			set
			{
				if (_iconBG == value)
				{
					return;
				}
				_iconBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("civilianIcon")] 
		public inkWidgetReference CivilianIcon
		{
			get
			{
				if (_civilianIcon == null)
				{
					_civilianIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "civilianIcon", cr2w, this);
				}
				return _civilianIcon;
			}
			set
			{
				if (_civilianIcon == value)
				{
					return;
				}
				_civilianIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("stealthMappinSlot")] 
		public inkCompoundWidgetReference StealthMappinSlot
		{
			get
			{
				if (_stealthMappinSlot == null)
				{
					_stealthMappinSlot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "stealthMappinSlot", cr2w, this);
				}
				return _stealthMappinSlot;
			}
			set
			{
				if (_stealthMappinSlot == value)
				{
					return;
				}
				_stealthMappinSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("iconTextWrapper")] 
		public inkCompoundWidgetReference IconTextWrapper
		{
			get
			{
				if (_iconTextWrapper == null)
				{
					_iconTextWrapper = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "iconTextWrapper", cr2w, this);
				}
				return _iconTextWrapper;
			}
			set
			{
				if (_iconTextWrapper == value)
				{
					return;
				}
				_iconTextWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("LevelcontainerAndText")] 
		public inkCompoundWidgetReference LevelcontainerAndText
		{
			get
			{
				if (_levelcontainerAndText == null)
				{
					_levelcontainerAndText = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "LevelcontainerAndText", cr2w, this);
				}
				return _levelcontainerAndText;
			}
			set
			{
				if (_levelcontainerAndText == value)
				{
					return;
				}
				_levelcontainerAndText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rareStars")] 
		public inkCompoundWidgetReference RareStars
		{
			get
			{
				if (_rareStars == null)
				{
					_rareStars = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "rareStars", cr2w, this);
				}
				return _rareStars;
			}
			set
			{
				if (_rareStars == value)
				{
					return;
				}
				_rareStars = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("eliteStars")] 
		public inkCompoundWidgetReference EliteStars
		{
			get
			{
				if (_eliteStars == null)
				{
					_eliteStars = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "eliteStars", cr2w, this);
				}
				return _eliteStars;
			}
			set
			{
				if (_eliteStars == value)
				{
					return;
				}
				_eliteStars = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("hardEnemy")] 
		public inkImageWidgetReference HardEnemy
		{
			get
			{
				if (_hardEnemy == null)
				{
					_hardEnemy = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "hardEnemy", cr2w, this);
				}
				return _hardEnemy;
			}
			set
			{
				if (_hardEnemy == value)
				{
					return;
				}
				_hardEnemy = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("hardEnemyWrapper")] 
		public inkWidgetReference HardEnemyWrapper
		{
			get
			{
				if (_hardEnemyWrapper == null)
				{
					_hardEnemyWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hardEnemyWrapper", cr2w, this);
				}
				return _hardEnemyWrapper;
			}
			set
			{
				if (_hardEnemyWrapper == value)
				{
					return;
				}
				_hardEnemyWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("damagePreviewWrapper")] 
		public inkWidgetReference DamagePreviewWrapper
		{
			get
			{
				if (_damagePreviewWrapper == null)
				{
					_damagePreviewWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damagePreviewWrapper", cr2w, this);
				}
				return _damagePreviewWrapper;
			}
			set
			{
				if (_damagePreviewWrapper == value)
				{
					return;
				}
				_damagePreviewWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("damagePreviewWidget")] 
		public inkWidgetReference DamagePreviewWidget
		{
			get
			{
				if (_damagePreviewWidget == null)
				{
					_damagePreviewWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damagePreviewWidget", cr2w, this);
				}
				return _damagePreviewWidget;
			}
			set
			{
				if (_damagePreviewWidget == value)
				{
					return;
				}
				_damagePreviewWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("damagePreviewArrow")] 
		public inkWidgetReference DamagePreviewArrow
		{
			get
			{
				if (_damagePreviewArrow == null)
				{
					_damagePreviewArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damagePreviewArrow", cr2w, this);
				}
				return _damagePreviewArrow;
			}
			set
			{
				if (_damagePreviewArrow == value)
				{
					return;
				}
				_damagePreviewArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("buffsList")] 
		public inkHorizontalPanelWidgetReference BuffsList
		{
			get
			{
				if (_buffsList == null)
				{
					_buffsList = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "buffsList", cr2w, this);
				}
				return _buffsList;
			}
			set
			{
				if (_buffsList == value)
				{
					return;
				}
				_buffsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("buffWidgets")] 
		public CArray<wCHandle<inkWidget>> BuffWidgets
		{
			get
			{
				if (_buffWidgets == null)
				{
					_buffWidgets = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "buffWidgets", cr2w, this);
				}
				return _buffWidgets;
			}
			set
			{
				if (_buffWidgets == value)
				{
					return;
				}
				_buffWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("cachedPuppet")] 
		public wCHandle<gameObject> CachedPuppet
		{
			get
			{
				if (_cachedPuppet == null)
				{
					_cachedPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "cachedPuppet", cr2w, this);
				}
				return _cachedPuppet;
			}
			set
			{
				if (_cachedPuppet == value)
				{
					return;
				}
				_cachedPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("cachedIncomingData")] 
		public gameuiNPCNextToTheCrosshair CachedIncomingData
		{
			get
			{
				if (_cachedIncomingData == null)
				{
					_cachedIncomingData = (gameuiNPCNextToTheCrosshair) CR2WTypeManager.Create("gameuiNPCNextToTheCrosshair", "cachedIncomingData", cr2w, this);
				}
				return _cachedIncomingData;
			}
			set
			{
				if (_cachedIncomingData == value)
				{
					return;
				}
				_cachedIncomingData = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("isOfficer")] 
		public CBool IsOfficer
		{
			get
			{
				if (_isOfficer == null)
				{
					_isOfficer = (CBool) CR2WTypeManager.Create("Bool", "isOfficer", cr2w, this);
				}
				return _isOfficer;
			}
			set
			{
				if (_isOfficer == value)
				{
					return;
				}
				_isOfficer = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("isBoss")] 
		public CBool IsBoss
		{
			get
			{
				if (_isBoss == null)
				{
					_isBoss = (CBool) CR2WTypeManager.Create("Bool", "isBoss", cr2w, this);
				}
				return _isBoss;
			}
			set
			{
				if (_isBoss == value)
				{
					return;
				}
				_isBoss = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("isElite")] 
		public CBool IsElite
		{
			get
			{
				if (_isElite == null)
				{
					_isElite = (CBool) CR2WTypeManager.Create("Bool", "isElite", cr2w, this);
				}
				return _isElite;
			}
			set
			{
				if (_isElite == value)
				{
					return;
				}
				_isElite = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("isRare")] 
		public CBool IsRare
		{
			get
			{
				if (_isRare == null)
				{
					_isRare = (CBool) CR2WTypeManager.Create("Bool", "isRare", cr2w, this);
				}
				return _isRare;
			}
			set
			{
				if (_isRare == value)
				{
					return;
				}
				_isRare = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get
			{
				if (_isPrevention == null)
				{
					_isPrevention = (CBool) CR2WTypeManager.Create("Bool", "isPrevention", cr2w, this);
				}
				return _isPrevention;
			}
			set
			{
				if (_isPrevention == value)
				{
					return;
				}
				_isPrevention = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("canCallReinforcements")] 
		public CBool CanCallReinforcements
		{
			get
			{
				if (_canCallReinforcements == null)
				{
					_canCallReinforcements = (CBool) CR2WTypeManager.Create("Bool", "canCallReinforcements", cr2w, this);
				}
				return _canCallReinforcements;
			}
			set
			{
				if (_canCallReinforcements == value)
				{
					return;
				}
				_canCallReinforcements = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get
			{
				if (_isCivilian == null)
				{
					_isCivilian = (CBool) CR2WTypeManager.Create("Bool", "isCivilian", cr2w, this);
				}
				return _isCivilian;
			}
			set
			{
				if (_isCivilian == value)
				{
					return;
				}
				_isCivilian = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("isBurning")] 
		public CBool IsBurning
		{
			get
			{
				if (_isBurning == null)
				{
					_isBurning = (CBool) CR2WTypeManager.Create("Bool", "isBurning", cr2w, this);
				}
				return _isBurning;
			}
			set
			{
				if (_isBurning == value)
				{
					return;
				}
				_isBurning = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("isPoisoned")] 
		public CBool IsPoisoned
		{
			get
			{
				if (_isPoisoned == null)
				{
					_isPoisoned = (CBool) CR2WTypeManager.Create("Bool", "isPoisoned", cr2w, this);
				}
				return _isPoisoned;
			}
			set
			{
				if (_isPoisoned == value)
				{
					return;
				}
				_isPoisoned = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("bossColor")] 
		public CColor BossColor
		{
			get
			{
				if (_bossColor == null)
				{
					_bossColor = (CColor) CR2WTypeManager.Create("Color", "bossColor", cr2w, this);
				}
				return _bossColor;
			}
			set
			{
				if (_bossColor == value)
				{
					return;
				}
				_bossColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("npcDefeated")] 
		public CBool NpcDefeated
		{
			get
			{
				if (_npcDefeated == null)
				{
					_npcDefeated = (CBool) CR2WTypeManager.Create("Bool", "npcDefeated", cr2w, this);
				}
				return _npcDefeated;
			}
			set
			{
				if (_npcDefeated == value)
				{
					return;
				}
				_npcDefeated = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("isStealthMappinVisible")] 
		public CBool IsStealthMappinVisible
		{
			get
			{
				if (_isStealthMappinVisible == null)
				{
					_isStealthMappinVisible = (CBool) CR2WTypeManager.Create("Bool", "isStealthMappinVisible", cr2w, this);
				}
				return _isStealthMappinVisible;
			}
			set
			{
				if (_isStealthMappinVisible == value)
				{
					return;
				}
				_isStealthMappinVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("playerZone")] 
		public CEnum<gamePSMZones> PlayerZone
		{
			get
			{
				if (_playerZone == null)
				{
					_playerZone = (CEnum<gamePSMZones>) CR2WTypeManager.Create("gamePSMZones", "playerZone", cr2w, this);
				}
				return _playerZone;
			}
			set
			{
				if (_playerZone == value)
				{
					return;
				}
				_playerZone = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get
			{
				if (_healthController == null)
				{
					_healthController = (wCHandle<NameplateBarLogicController>) CR2WTypeManager.Create("whandle:NameplateBarLogicController", "healthController", cr2w, this);
				}
				return _healthController;
			}
			set
			{
				if (_healthController == value)
				{
					return;
				}
				_healthController = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("hasCenterIcon")] 
		public CBool HasCenterIcon
		{
			get
			{
				if (_hasCenterIcon == null)
				{
					_hasCenterIcon = (CBool) CR2WTypeManager.Create("Bool", "hasCenterIcon", cr2w, this);
				}
				return _hasCenterIcon;
			}
			set
			{
				if (_hasCenterIcon == value)
				{
					return;
				}
				_hasCenterIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("animatingObject")] 
		public inkWidgetReference AnimatingObject
		{
			get
			{
				if (_animatingObject == null)
				{
					_animatingObject = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animatingObject", cr2w, this);
				}
				return _animatingObject;
			}
			set
			{
				if (_animatingObject == value)
				{
					return;
				}
				_animatingObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get
			{
				if (_isAnimating == null)
				{
					_isAnimating = (CBool) CR2WTypeManager.Create("Bool", "isAnimating", cr2w, this);
				}
				return _isAnimating;
			}
			set
			{
				if (_isAnimating == value)
				{
					return;
				}
				_isAnimating = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get
			{
				if (_alpha_fadein == null)
				{
					_alpha_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_fadein", cr2w, this);
				}
				return _alpha_fadein;
			}
			set
			{
				if (_alpha_fadein == value)
				{
					return;
				}
				_alpha_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("preventionAnimProxy")] 
		public CHandle<inkanimProxy> PreventionAnimProxy
		{
			get
			{
				if (_preventionAnimProxy == null)
				{
					_preventionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "preventionAnimProxy", cr2w, this);
				}
				return _preventionAnimProxy;
			}
			set
			{
				if (_preventionAnimProxy == value)
				{
					return;
				}
				_preventionAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("damagePreviewAnimProxy")] 
		public CHandle<inkanimProxy> DamagePreviewAnimProxy
		{
			get
			{
				if (_damagePreviewAnimProxy == null)
				{
					_damagePreviewAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "damagePreviewAnimProxy", cr2w, this);
				}
				return _damagePreviewAnimProxy;
			}
			set
			{
				if (_damagePreviewAnimProxy == value)
				{
					return;
				}
				_damagePreviewAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("isQuestTarget")] 
		public CBool IsQuestTarget
		{
			get
			{
				if (_isQuestTarget == null)
				{
					_isQuestTarget = (CBool) CR2WTypeManager.Create("Bool", "isQuestTarget", cr2w, this);
				}
				return _isQuestTarget;
			}
			set
			{
				if (_isQuestTarget == value)
				{
					return;
				}
				_isQuestTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("forceHide")] 
		public CBool ForceHide
		{
			get
			{
				if (_forceHide == null)
				{
					_forceHide = (CBool) CR2WTypeManager.Create("Bool", "forceHide", cr2w, this);
				}
				return _forceHide;
			}
			set
			{
				if (_forceHide == value)
				{
					return;
				}
				_forceHide = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("isHardEnemy")] 
		public CBool IsHardEnemy
		{
			get
			{
				if (_isHardEnemy == null)
				{
					_isHardEnemy = (CBool) CR2WTypeManager.Create("Bool", "isHardEnemy", cr2w, this);
				}
				return _isHardEnemy;
			}
			set
			{
				if (_isHardEnemy == value)
				{
					return;
				}
				_isHardEnemy = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("npcIsAggressive")] 
		public CBool NpcIsAggressive
		{
			get
			{
				if (_npcIsAggressive == null)
				{
					_npcIsAggressive = (CBool) CR2WTypeManager.Create("Bool", "npcIsAggressive", cr2w, this);
				}
				return _npcIsAggressive;
			}
			set
			{
				if (_npcIsAggressive == value)
				{
					return;
				}
				_npcIsAggressive = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("playerAimingDownSights")] 
		public CBool PlayerAimingDownSights
		{
			get
			{
				if (_playerAimingDownSights == null)
				{
					_playerAimingDownSights = (CBool) CR2WTypeManager.Create("Bool", "playerAimingDownSights", cr2w, this);
				}
				return _playerAimingDownSights;
			}
			set
			{
				if (_playerAimingDownSights == value)
				{
					return;
				}
				_playerAimingDownSights = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get
			{
				if (_playerInCombat == null)
				{
					_playerInCombat = (CBool) CR2WTypeManager.Create("Bool", "playerInCombat", cr2w, this);
				}
				return _playerInCombat;
			}
			set
			{
				if (_playerInCombat == value)
				{
					return;
				}
				_playerInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("playerInStealth")] 
		public CBool PlayerInStealth
		{
			get
			{
				if (_playerInStealth == null)
				{
					_playerInStealth = (CBool) CR2WTypeManager.Create("Bool", "playerInStealth", cr2w, this);
				}
				return _playerInStealth;
			}
			set
			{
				if (_playerInStealth == value)
				{
					return;
				}
				_playerInStealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("healthNotFull")] 
		public CBool HealthNotFull
		{
			get
			{
				if (_healthNotFull == null)
				{
					_healthNotFull = (CBool) CR2WTypeManager.Create("Bool", "healthNotFull", cr2w, this);
				}
				return _healthNotFull;
			}
			set
			{
				if (_healthNotFull == value)
				{
					return;
				}
				_healthNotFull = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("healthbarVisible")] 
		public CBool HealthbarVisible
		{
			get
			{
				if (_healthbarVisible == null)
				{
					_healthbarVisible = (CBool) CR2WTypeManager.Create("Bool", "healthbarVisible", cr2w, this);
				}
				return _healthbarVisible;
			}
			set
			{
				if (_healthbarVisible == value)
				{
					return;
				}
				_healthbarVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("levelContainerShouldBeVisible")] 
		public CBool LevelContainerShouldBeVisible
		{
			get
			{
				if (_levelContainerShouldBeVisible == null)
				{
					_levelContainerShouldBeVisible = (CBool) CR2WTypeManager.Create("Bool", "levelContainerShouldBeVisible", cr2w, this);
				}
				return _levelContainerShouldBeVisible;
			}
			set
			{
				if (_levelContainerShouldBeVisible == value)
				{
					return;
				}
				_levelContainerShouldBeVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (CInt32) CR2WTypeManager.Create("Int32", "currentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get
			{
				if (_maximumHealth == null)
				{
					_maximumHealth = (CInt32) CR2WTypeManager.Create("Int32", "maximumHealth", cr2w, this);
				}
				return _maximumHealth;
			}
			set
			{
				if (_maximumHealth == value)
				{
					return;
				}
				_maximumHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("currentDamagePreviewValue")] 
		public CInt32 CurrentDamagePreviewValue
		{
			get
			{
				if (_currentDamagePreviewValue == null)
				{
					_currentDamagePreviewValue = (CInt32) CR2WTypeManager.Create("Int32", "currentDamagePreviewValue", cr2w, this);
				}
				return _currentDamagePreviewValue;
			}
			set
			{
				if (_currentDamagePreviewValue == value)
				{
					return;
				}
				_currentDamagePreviewValue = value;
				PropertySet(this);
			}
		}

		public NameplateVisualsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
