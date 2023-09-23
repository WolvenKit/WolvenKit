using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScriptedWeakspotObject : gameWeakspotObject
	{
		[Ordinal(36)] 
		[RED("weakspotOnDestroyProperties")] 
		public WeakspotOnDestroyProperties WeakspotOnDestroyProperties
		{
			get => GetPropertyValue<WeakspotOnDestroyProperties>();
			set => SetPropertyValue<WeakspotOnDestroyProperties>(value);
		}

		[Ordinal(37)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(38)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("targeting")] 
		public CHandle<gameTargetingComponent> Targeting
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(40)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(42)] 
		[RED("weakspotRecordData")] 
		public WeakspotRecordData WeakspotRecordData
		{
			get => GetPropertyValue<WeakspotRecordData>();
			set => SetPropertyValue<WeakspotRecordData>(value);
		}

		[Ordinal(43)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("hasBeenScanned")] 
		public CBool HasBeenScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(46)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(47)] 
		[RED("healthListener")] 
		public CHandle<WeakspotHealthChangeListener> HealthListener
		{
			get => GetPropertyValue<CHandle<WeakspotHealthChangeListener>>();
			set => SetPropertyValue<CHandle<WeakspotHealthChangeListener>>(value);
		}

		[Ordinal(48)] 
		[RED("parentMaxhealth")] 
		public CFloat ParentMaxhealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("blockHighlight")] 
		public CBool BlockHighlight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("blockDamage")] 
		public CBool BlockDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScriptedWeakspotObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
