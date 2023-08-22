using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OdaComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(7)] 
		[RED("odaAIComponent")] 
		public CHandle<AIHumanComponent> OdaAIComponent
		{
			get => GetPropertyValue<CHandle<AIHumanComponent>>();
			set => SetPropertyValue<CHandle<AIHumanComponent>>(value);
		}

		[Ordinal(8)] 
		[RED("actionBlackBoard")] 
		public CWeakHandle<gameIBlackboard> ActionBlackBoard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(9)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(10)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(11)] 
		[RED("healthListener")] 
		public CHandle<OdaEmergencyListener> HealthListener
		{
			get => GetPropertyValue<CHandle<OdaEmergencyListener>>();
			set => SetPropertyValue<CHandle<OdaEmergencyListener>>(value);
		}

		[Ordinal(12)] 
		[RED("statusEffect_emergency")] 
		public TweakDBID StatusEffect_emergency
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CHandle<AITargetTrackerComponent>>(value);
		}

		public OdaComponent()
		{
			Owner_id = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
