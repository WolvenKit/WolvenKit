using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChimeraComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(8)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(9)] 
		[RED("npcDeathCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(10)] 
		[RED("targetingBody")] 
		public CHandle<gameTargetingComponent> TargetingBody
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(11)] 
		[RED("healthListener")] 
		public CHandle<ChimeraHealthChangeListener> HealthListener
		{
			get => GetPropertyValue<CHandle<ChimeraHealthChangeListener>>();
			set => SetPropertyValue<CHandle<ChimeraHealthChangeListener>>(value);
		}

		[Ordinal(12)] 
		[RED("defeatedOnAttach")] 
		public CBool DefeatedOnAttach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetPropertyValue<CHandle<gameWeakspotComponent>>();
			set => SetPropertyValue<CHandle<gameWeakspotComponent>>(value);
		}

		[Ordinal(14)] 
		[RED("weakspots")] 
		public CArray<CWeakHandle<gameWeakspotObject>> Weakspots
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameWeakspotObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameWeakspotObject>>>(value);
		}

		[Ordinal(15)] 
		[RED("weakspotsInvulnerable")] 
		public CBool WeakspotsInvulnerable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("weakspotsDelay")] 
		public gameDelayID WeakspotsDelay
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(17)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CHandle<AITargetTrackerComponent>>(value);
		}

		public ChimeraComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
