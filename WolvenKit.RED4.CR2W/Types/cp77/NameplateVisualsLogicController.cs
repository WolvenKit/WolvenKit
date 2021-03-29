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
		private CBool _npcNamesEnabled;
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
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(2)] 
		[RED("bigIconMain")] 
		public inkWidgetReference BigIconMain
		{
			get => GetProperty(ref _bigIconMain);
			set => SetProperty(ref _bigIconMain, value);
		}

		[Ordinal(3)] 
		[RED("bigLevelText")] 
		public inkTextWidgetReference BigLevelText
		{
			get => GetProperty(ref _bigLevelText);
			set => SetProperty(ref _bigLevelText, value);
		}

		[Ordinal(4)] 
		[RED("nameTextMain")] 
		public inkTextWidgetReference NameTextMain
		{
			get => GetProperty(ref _nameTextMain);
			set => SetProperty(ref _nameTextMain, value);
		}

		[Ordinal(5)] 
		[RED("bigIconArt")] 
		public inkImageWidgetReference BigIconArt
		{
			get => GetProperty(ref _bigIconArt);
			set => SetProperty(ref _bigIconArt, value);
		}

		[Ordinal(6)] 
		[RED("preventionIcon")] 
		public inkWidgetReference PreventionIcon
		{
			get => GetProperty(ref _preventionIcon);
			set => SetProperty(ref _preventionIcon, value);
		}

		[Ordinal(7)] 
		[RED("levelContainer")] 
		public inkImageWidgetReference LevelContainer
		{
			get => GetProperty(ref _levelContainer);
			set => SetProperty(ref _levelContainer, value);
		}

		[Ordinal(8)] 
		[RED("nameFrame")] 
		public inkWidgetReference NameFrame
		{
			get => GetProperty(ref _nameFrame);
			set => SetProperty(ref _nameFrame, value);
		}

		[Ordinal(9)] 
		[RED("healthbarWidget")] 
		public inkWidgetReference HealthbarWidget
		{
			get => GetProperty(ref _healthbarWidget);
			set => SetProperty(ref _healthbarWidget, value);
		}

		[Ordinal(10)] 
		[RED("healthBarFull")] 
		public inkWidgetReference HealthBarFull
		{
			get => GetProperty(ref _healthBarFull);
			set => SetProperty(ref _healthBarFull, value);
		}

		[Ordinal(11)] 
		[RED("healthBarFrame")] 
		public inkWidgetReference HealthBarFrame
		{
			get => GetProperty(ref _healthBarFrame);
			set => SetProperty(ref _healthBarFrame, value);
		}

		[Ordinal(12)] 
		[RED("taggedIcon")] 
		public inkWidgetReference TaggedIcon
		{
			get => GetProperty(ref _taggedIcon);
			set => SetProperty(ref _taggedIcon, value);
		}

		[Ordinal(13)] 
		[RED("iconBG")] 
		public inkWidgetReference IconBG
		{
			get => GetProperty(ref _iconBG);
			set => SetProperty(ref _iconBG, value);
		}

		[Ordinal(14)] 
		[RED("civilianIcon")] 
		public inkWidgetReference CivilianIcon
		{
			get => GetProperty(ref _civilianIcon);
			set => SetProperty(ref _civilianIcon, value);
		}

		[Ordinal(15)] 
		[RED("stealthMappinSlot")] 
		public inkCompoundWidgetReference StealthMappinSlot
		{
			get => GetProperty(ref _stealthMappinSlot);
			set => SetProperty(ref _stealthMappinSlot, value);
		}

		[Ordinal(16)] 
		[RED("iconTextWrapper")] 
		public inkCompoundWidgetReference IconTextWrapper
		{
			get => GetProperty(ref _iconTextWrapper);
			set => SetProperty(ref _iconTextWrapper, value);
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(18)] 
		[RED("LevelcontainerAndText")] 
		public inkCompoundWidgetReference LevelcontainerAndText
		{
			get => GetProperty(ref _levelcontainerAndText);
			set => SetProperty(ref _levelcontainerAndText, value);
		}

		[Ordinal(19)] 
		[RED("rareStars")] 
		public inkCompoundWidgetReference RareStars
		{
			get => GetProperty(ref _rareStars);
			set => SetProperty(ref _rareStars, value);
		}

		[Ordinal(20)] 
		[RED("eliteStars")] 
		public inkCompoundWidgetReference EliteStars
		{
			get => GetProperty(ref _eliteStars);
			set => SetProperty(ref _eliteStars, value);
		}

		[Ordinal(21)] 
		[RED("hardEnemy")] 
		public inkImageWidgetReference HardEnemy
		{
			get => GetProperty(ref _hardEnemy);
			set => SetProperty(ref _hardEnemy, value);
		}

		[Ordinal(22)] 
		[RED("hardEnemyWrapper")] 
		public inkWidgetReference HardEnemyWrapper
		{
			get => GetProperty(ref _hardEnemyWrapper);
			set => SetProperty(ref _hardEnemyWrapper, value);
		}

		[Ordinal(23)] 
		[RED("damagePreviewWrapper")] 
		public inkWidgetReference DamagePreviewWrapper
		{
			get => GetProperty(ref _damagePreviewWrapper);
			set => SetProperty(ref _damagePreviewWrapper, value);
		}

		[Ordinal(24)] 
		[RED("damagePreviewWidget")] 
		public inkWidgetReference DamagePreviewWidget
		{
			get => GetProperty(ref _damagePreviewWidget);
			set => SetProperty(ref _damagePreviewWidget, value);
		}

		[Ordinal(25)] 
		[RED("damagePreviewArrow")] 
		public inkWidgetReference DamagePreviewArrow
		{
			get => GetProperty(ref _damagePreviewArrow);
			set => SetProperty(ref _damagePreviewArrow, value);
		}

		[Ordinal(26)] 
		[RED("buffsList")] 
		public inkHorizontalPanelWidgetReference BuffsList
		{
			get => GetProperty(ref _buffsList);
			set => SetProperty(ref _buffsList, value);
		}

		[Ordinal(27)] 
		[RED("buffWidgets")] 
		public CArray<wCHandle<inkWidget>> BuffWidgets
		{
			get => GetProperty(ref _buffWidgets);
			set => SetProperty(ref _buffWidgets, value);
		}

		[Ordinal(28)] 
		[RED("cachedPuppet")] 
		public wCHandle<gameObject> CachedPuppet
		{
			get => GetProperty(ref _cachedPuppet);
			set => SetProperty(ref _cachedPuppet, value);
		}

		[Ordinal(29)] 
		[RED("cachedIncomingData")] 
		public gameuiNPCNextToTheCrosshair CachedIncomingData
		{
			get => GetProperty(ref _cachedIncomingData);
			set => SetProperty(ref _cachedIncomingData, value);
		}

		[Ordinal(30)] 
		[RED("isOfficer")] 
		public CBool IsOfficer
		{
			get => GetProperty(ref _isOfficer);
			set => SetProperty(ref _isOfficer, value);
		}

		[Ordinal(31)] 
		[RED("isBoss")] 
		public CBool IsBoss
		{
			get => GetProperty(ref _isBoss);
			set => SetProperty(ref _isBoss, value);
		}

		[Ordinal(32)] 
		[RED("isElite")] 
		public CBool IsElite
		{
			get => GetProperty(ref _isElite);
			set => SetProperty(ref _isElite, value);
		}

		[Ordinal(33)] 
		[RED("isRare")] 
		public CBool IsRare
		{
			get => GetProperty(ref _isRare);
			set => SetProperty(ref _isRare, value);
		}

		[Ordinal(34)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get => GetProperty(ref _isPrevention);
			set => SetProperty(ref _isPrevention, value);
		}

		[Ordinal(35)] 
		[RED("canCallReinforcements")] 
		public CBool CanCallReinforcements
		{
			get => GetProperty(ref _canCallReinforcements);
			set => SetProperty(ref _canCallReinforcements, value);
		}

		[Ordinal(36)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetProperty(ref _isCivilian);
			set => SetProperty(ref _isCivilian, value);
		}

		[Ordinal(37)] 
		[RED("isBurning")] 
		public CBool IsBurning
		{
			get => GetProperty(ref _isBurning);
			set => SetProperty(ref _isBurning, value);
		}

		[Ordinal(38)] 
		[RED("isPoisoned")] 
		public CBool IsPoisoned
		{
			get => GetProperty(ref _isPoisoned);
			set => SetProperty(ref _isPoisoned, value);
		}

		[Ordinal(39)] 
		[RED("bossColor")] 
		public CColor BossColor
		{
			get => GetProperty(ref _bossColor);
			set => SetProperty(ref _bossColor, value);
		}

		[Ordinal(40)] 
		[RED("npcDefeated")] 
		public CBool NpcDefeated
		{
			get => GetProperty(ref _npcDefeated);
			set => SetProperty(ref _npcDefeated, value);
		}

		[Ordinal(41)] 
		[RED("isStealthMappinVisible")] 
		public CBool IsStealthMappinVisible
		{
			get => GetProperty(ref _isStealthMappinVisible);
			set => SetProperty(ref _isStealthMappinVisible, value);
		}

		[Ordinal(42)] 
		[RED("playerZone")] 
		public CEnum<gamePSMZones> PlayerZone
		{
			get => GetProperty(ref _playerZone);
			set => SetProperty(ref _playerZone, value);
		}

		[Ordinal(43)] 
		[RED("npcNamesEnabled")] 
		public CBool NpcNamesEnabled
		{
			get => GetProperty(ref _npcNamesEnabled);
			set => SetProperty(ref _npcNamesEnabled, value);
		}

		[Ordinal(44)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get => GetProperty(ref _healthController);
			set => SetProperty(ref _healthController, value);
		}

		[Ordinal(45)] 
		[RED("hasCenterIcon")] 
		public CBool HasCenterIcon
		{
			get => GetProperty(ref _hasCenterIcon);
			set => SetProperty(ref _hasCenterIcon, value);
		}

		[Ordinal(46)] 
		[RED("animatingObject")] 
		public inkWidgetReference AnimatingObject
		{
			get => GetProperty(ref _animatingObject);
			set => SetProperty(ref _animatingObject, value);
		}

		[Ordinal(47)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get => GetProperty(ref _isAnimating);
			set => SetProperty(ref _isAnimating, value);
		}

		[Ordinal(48)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(49)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(50)] 
		[RED("preventionAnimProxy")] 
		public CHandle<inkanimProxy> PreventionAnimProxy
		{
			get => GetProperty(ref _preventionAnimProxy);
			set => SetProperty(ref _preventionAnimProxy, value);
		}

		[Ordinal(51)] 
		[RED("damagePreviewAnimProxy")] 
		public CHandle<inkanimProxy> DamagePreviewAnimProxy
		{
			get => GetProperty(ref _damagePreviewAnimProxy);
			set => SetProperty(ref _damagePreviewAnimProxy, value);
		}

		[Ordinal(52)] 
		[RED("isQuestTarget")] 
		public CBool IsQuestTarget
		{
			get => GetProperty(ref _isQuestTarget);
			set => SetProperty(ref _isQuestTarget, value);
		}

		[Ordinal(53)] 
		[RED("forceHide")] 
		public CBool ForceHide
		{
			get => GetProperty(ref _forceHide);
			set => SetProperty(ref _forceHide, value);
		}

		[Ordinal(54)] 
		[RED("isHardEnemy")] 
		public CBool IsHardEnemy
		{
			get => GetProperty(ref _isHardEnemy);
			set => SetProperty(ref _isHardEnemy, value);
		}

		[Ordinal(55)] 
		[RED("npcIsAggressive")] 
		public CBool NpcIsAggressive
		{
			get => GetProperty(ref _npcIsAggressive);
			set => SetProperty(ref _npcIsAggressive, value);
		}

		[Ordinal(56)] 
		[RED("playerAimingDownSights")] 
		public CBool PlayerAimingDownSights
		{
			get => GetProperty(ref _playerAimingDownSights);
			set => SetProperty(ref _playerAimingDownSights, value);
		}

		[Ordinal(57)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetProperty(ref _playerInCombat);
			set => SetProperty(ref _playerInCombat, value);
		}

		[Ordinal(58)] 
		[RED("playerInStealth")] 
		public CBool PlayerInStealth
		{
			get => GetProperty(ref _playerInStealth);
			set => SetProperty(ref _playerInStealth, value);
		}

		[Ordinal(59)] 
		[RED("healthNotFull")] 
		public CBool HealthNotFull
		{
			get => GetProperty(ref _healthNotFull);
			set => SetProperty(ref _healthNotFull, value);
		}

		[Ordinal(60)] 
		[RED("healthbarVisible")] 
		public CBool HealthbarVisible
		{
			get => GetProperty(ref _healthbarVisible);
			set => SetProperty(ref _healthbarVisible, value);
		}

		[Ordinal(61)] 
		[RED("levelContainerShouldBeVisible")] 
		public CBool LevelContainerShouldBeVisible
		{
			get => GetProperty(ref _levelContainerShouldBeVisible);
			set => SetProperty(ref _levelContainerShouldBeVisible, value);
		}

		[Ordinal(62)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(63)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(64)] 
		[RED("currentDamagePreviewValue")] 
		public CInt32 CurrentDamagePreviewValue
		{
			get => GetProperty(ref _currentDamagePreviewValue);
			set => SetProperty(ref _currentDamagePreviewValue, value);
		}

		public NameplateVisualsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
