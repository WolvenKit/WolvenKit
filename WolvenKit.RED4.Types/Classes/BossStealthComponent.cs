using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BossStealthComponent : gameScriptableComponent
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
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(8)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(9)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CHandle<AITargetTrackerComponent>>(value);
		}

		public BossStealthComponent()
		{
			Owner_id = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
