using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RoyceComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(7)] 
		[RED("npcDeathCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(8)] 
		[RED("npcHitRepresentationComponent")] 
		public CHandle<entIComponent> NpcHitRepresentationComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(9)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		public RoyceComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
