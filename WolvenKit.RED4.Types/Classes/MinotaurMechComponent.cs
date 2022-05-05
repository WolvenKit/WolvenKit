using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinotaurMechComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("deathAttackRecordID")] 
		public TweakDBID DeathAttackRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(7)] 
		[RED("statusEffectListener")] 
		public CHandle<MinotaurOnStatusEffectAppliedListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<MinotaurOnStatusEffectAppliedListener>>();
			set => SetPropertyValue<CHandle<MinotaurOnStatusEffectAppliedListener>>(value);
		}

		[Ordinal(8)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(9)] 
		[RED("npcDeathCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(10)] 
		[RED("npcSystemCollapseCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcSystemCollapseCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(11)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get => GetPropertyValue<CEnum<MechanicalScanType>>();
			set => SetPropertyValue<CEnum<MechanicalScanType>>(value);
		}

		[Ordinal(12)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public MinotaurMechComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
