using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class mpPersistentTestBoxState : netIEntityState
	{
		[Ordinal(2)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("weakPersistentEntity")] 
		public CWeakHandle<mpPersistentTestBox> WeakPersistentEntity
		{
			get => GetPropertyValue<CWeakHandle<mpPersistentTestBox>>();
			set => SetPropertyValue<CWeakHandle<mpPersistentTestBox>>(value);
		}

		[Ordinal(4)] 
		[RED("weakPersistentEntityComponent")] 
		public CWeakHandle<entIComponent> WeakPersistentEntityComponent
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		[Ordinal(5)] 
		[RED("weakDynamicEntity")] 
		public CWeakHandle<gameObject> WeakDynamicEntity
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("weakDynamicEntityComponent")] 
		public CWeakHandle<entIComponent> WeakDynamicEntityComponent
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		public mpPersistentTestBoxState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
