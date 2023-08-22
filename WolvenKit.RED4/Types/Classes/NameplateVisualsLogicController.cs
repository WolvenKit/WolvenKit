using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NameplateVisualsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("bigIconMain")] 
		public inkWidgetReference BigIconMain
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("bigLevelText")] 
		public inkTextWidgetReference BigLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("nameTextMain")] 
		public inkTextWidgetReference NameTextMain
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("bigIconArt")] 
		public inkImageWidgetReference BigIconArt
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("preventionIcon")] 
		public inkWidgetReference PreventionIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("levelContainer")] 
		public inkImageWidgetReference LevelContainer
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("nameFrame")] 
		public inkWidgetReference NameFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("healthbarWidget")] 
		public inkWidgetReference HealthbarWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("healthBarFull")] 
		public inkWidgetReference HealthBarFull
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("healthBarFrame")] 
		public inkWidgetReference HealthBarFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("taggedIcon")] 
		public inkWidgetReference TaggedIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("iconBG")] 
		public inkWidgetReference IconBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("civilianIcon")] 
		public inkWidgetReference CivilianIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("stealthMappinSlot")] 
		public inkCompoundWidgetReference StealthMappinSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("iconTextWrapper")] 
		public inkCompoundWidgetReference IconTextWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("LevelcontainerAndText")] 
		public inkCompoundWidgetReference LevelcontainerAndText
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("rareStars")] 
		public inkCompoundWidgetReference RareStars
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("eliteStars")] 
		public inkCompoundWidgetReference EliteStars
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("hardEnemy")] 
		public inkImageWidgetReference HardEnemy
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("hardEnemyWrapper")] 
		public inkWidgetReference HardEnemyWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("damagePreviewWrapper")] 
		public inkWidgetReference DamagePreviewWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("damagePreviewWidget")] 
		public inkWidgetReference DamagePreviewWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("damagePreviewArrow")] 
		public inkWidgetReference DamagePreviewArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("buffsList")] 
		public inkHorizontalPanelWidgetReference BuffsList
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("buffWidgets")] 
		public CArray<CWeakHandle<inkWidget>> BuffWidgets
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(28)] 
		[RED("cachedPuppet")] 
		public CWeakHandle<gameObject> CachedPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(29)] 
		[RED("cachedIncomingData")] 
		public gameuiNPCNextToTheCrosshair CachedIncomingData
		{
			get => GetPropertyValue<gameuiNPCNextToTheCrosshair>();
			set => SetPropertyValue<gameuiNPCNextToTheCrosshair>(value);
		}

		[Ordinal(30)] 
		[RED("isOfficer")] 
		public CBool IsOfficer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isBoss")] 
		public CBool IsBoss
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isElite")] 
		public CBool IsElite
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("isRare")] 
		public CBool IsRare
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("canCallReinforcements")] 
		public CBool CanCallReinforcements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("isBurning")] 
		public CBool IsBurning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isPoisoned")] 
		public CBool IsPoisoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("bossColor")] 
		public CColor BossColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(40)] 
		[RED("npcDefeated")] 
		public CBool NpcDefeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("isStealthMappinVisible")] 
		public CBool IsStealthMappinVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("playerZone")] 
		public CEnum<gamePSMZones> PlayerZone
		{
			get => GetPropertyValue<CEnum<gamePSMZones>>();
			set => SetPropertyValue<CEnum<gamePSMZones>>(value);
		}

		[Ordinal(43)] 
		[RED("npcNamesEnabled")] 
		public CBool NpcNamesEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("healthController")] 
		public CWeakHandle<NameplateBarLogicController> HealthController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(45)] 
		[RED("hasCenterIcon")] 
		public CBool HasCenterIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("animatingObject")] 
		public inkWidgetReference AnimatingObject
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(49)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(50)] 
		[RED("preventionAnimProxy")] 
		public CHandle<inkanimProxy> PreventionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(51)] 
		[RED("damagePreviewAnimProxy")] 
		public CHandle<inkanimProxy> DamagePreviewAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(52)] 
		[RED("isQuestTarget")] 
		public CBool IsQuestTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("forceHide")] 
		public CBool ForceHide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("isHardEnemy")] 
		public CBool IsHardEnemy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("npcIsAggressive")] 
		public CBool NpcIsAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("playerAimingDownSights")] 
		public CBool PlayerAimingDownSights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("playerInStealth")] 
		public CBool PlayerInStealth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("healthNotFull")] 
		public CBool HealthNotFull
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("healthbarVisible")] 
		public CBool HealthbarVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("levelContainerShouldBeVisible")] 
		public CBool LevelContainerShouldBeVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(63)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(64)] 
		[RED("currentDamagePreviewValue")] 
		public CInt32 CurrentDamagePreviewValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NameplateVisualsLogicController()
		{
			BigIconMain = new inkWidgetReference();
			BigLevelText = new inkTextWidgetReference();
			NameTextMain = new inkTextWidgetReference();
			BigIconArt = new inkImageWidgetReference();
			PreventionIcon = new inkWidgetReference();
			LevelContainer = new inkImageWidgetReference();
			NameFrame = new inkWidgetReference();
			HealthbarWidget = new inkWidgetReference();
			HealthBarFull = new inkWidgetReference();
			HealthBarFrame = new inkWidgetReference();
			TaggedIcon = new inkWidgetReference();
			IconBG = new inkWidgetReference();
			CivilianIcon = new inkWidgetReference();
			StealthMappinSlot = new inkCompoundWidgetReference();
			IconTextWrapper = new inkCompoundWidgetReference();
			Container = new inkWidgetReference();
			LevelcontainerAndText = new inkCompoundWidgetReference();
			RareStars = new inkCompoundWidgetReference();
			EliteStars = new inkCompoundWidgetReference();
			HardEnemy = new inkImageWidgetReference();
			HardEnemyWrapper = new inkWidgetReference();
			DamagePreviewWrapper = new inkWidgetReference();
			DamagePreviewWidget = new inkWidgetReference();
			DamagePreviewArrow = new inkWidgetReference();
			BuffsList = new inkHorizontalPanelWidgetReference();
			BuffWidgets = new();
			CachedIncomingData = new gameuiNPCNextToTheCrosshair { Attitude = Enums.EAIAttitude.AIA_Neutral, HighLevelState = Enums.gamedataNPCHighLevelState.Any };
			BossColor = new CColor();
			AnimatingObject = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
