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
		[RED("nameTextMain")] 
		public inkTextWidgetReference NameTextMain
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("nameFrame")] 
		public inkWidgetReference NameFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("healthbarWidget")] 
		public inkWidgetReference HealthbarWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("healthBarFull")] 
		public inkWidgetReference HealthBarFull
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("healthBarFrame")] 
		public inkWidgetReference HealthBarFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("stealthMappinSlot")] 
		public inkCompoundWidgetReference StealthMappinSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("damagePreviewWrapper")] 
		public inkWidgetReference DamagePreviewWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("damagePreviewWidget")] 
		public inkWidgetReference DamagePreviewWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("damagePreviewArrow")] 
		public inkWidgetReference DamagePreviewArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("rarityHolder")] 
		public inkWidgetReference RarityHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("rarities")] 
		public CArray<inkWidgetReference> Rarities
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(13)] 
		[RED("cachedPuppet")] 
		public CWeakHandle<gameObject> CachedPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(14)] 
		[RED("cachedIncomingData")] 
		public gameuiNPCNextToTheCrosshair CachedIncomingData
		{
			get => GetPropertyValue<gameuiNPCNextToTheCrosshair>();
			set => SetPropertyValue<gameuiNPCNextToTheCrosshair>(value);
		}

		[Ordinal(15)] 
		[RED("isBoss")] 
		public CBool IsBoss
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isElite")] 
		public CBool IsElite
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("isRare")] 
		public CBool IsRare
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isNCPD")] 
		public CBool IsNCPD
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("canCallReinforcements")] 
		public CBool CanCallReinforcements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("isBurning")] 
		public CBool IsBurning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("isPoisoned")] 
		public CBool IsPoisoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("bossColor")] 
		public CColor BossColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(23)] 
		[RED("npcDefeated")] 
		public CBool NpcDefeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isStealthMappinVisible")] 
		public CBool IsStealthMappinVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("playerZone")] 
		public CEnum<gamePSMZones> PlayerZone
		{
			get => GetPropertyValue<CEnum<gamePSMZones>>();
			set => SetPropertyValue<CEnum<gamePSMZones>>(value);
		}

		[Ordinal(26)] 
		[RED("npcNamesEnabled")] 
		public CBool NpcNamesEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("healthController")] 
		public CWeakHandle<NameplateBarLogicController> HealthController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(28)] 
		[RED("hasCenterIcon")] 
		public CBool HasCenterIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("animatingObject")] 
		public inkWidgetReference AnimatingObject
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(32)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(33)] 
		[RED("damagePreviewAnimProxy")] 
		public CHandle<inkanimProxy> DamagePreviewAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(34)] 
		[RED("isQuestTarget")] 
		public CBool IsQuestTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("forceHide")] 
		public CBool ForceHide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isHardEnemy")] 
		public CBool IsHardEnemy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("npcIsAggressive")] 
		public CBool NpcIsAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("playerAimingDownSights")] 
		public CBool PlayerAimingDownSights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("playerInStealth")] 
		public CBool PlayerInStealth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("healthNotFull")] 
		public CBool HealthNotFull
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("healthbarVisible")] 
		public CBool HealthbarVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("levelContainerShouldBeVisible")] 
		public CBool LevelContainerShouldBeVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(46)] 
		[RED("currentDamagePreviewValue")] 
		public CInt32 CurrentDamagePreviewValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NameplateVisualsLogicController()
		{
			NameTextMain = new inkTextWidgetReference();
			NameFrame = new inkWidgetReference();
			HealthbarWidget = new inkWidgetReference();
			HealthBarFull = new inkWidgetReference();
			HealthBarFrame = new inkWidgetReference();
			StealthMappinSlot = new inkCompoundWidgetReference();
			DamagePreviewWrapper = new inkWidgetReference();
			DamagePreviewWidget = new inkWidgetReference();
			DamagePreviewArrow = new inkWidgetReference();
			RarityHolder = new inkWidgetReference();
			Rarities = new();
			CachedIncomingData = new gameuiNPCNextToTheCrosshair { Attitude = Enums.EAIAttitude.AIA_Neutral, HighLevelState = Enums.gamedataNPCHighLevelState.Any };
			BossColor = new CColor();
			AnimatingObject = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
