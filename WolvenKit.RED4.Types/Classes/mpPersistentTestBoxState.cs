using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class mpPersistentTestBoxState : netIEntityState
	{
		private CBool _isOn;
		private CWeakHandle<mpPersistentTestBox> _weakPersistentEntity;
		private CWeakHandle<entIComponent> _weakPersistentEntityComponent;
		private CWeakHandle<gameObject> _weakDynamicEntity;
		private CWeakHandle<entIComponent> _weakDynamicEntityComponent;

		[Ordinal(2)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetProperty(ref _isOn);
			set => SetProperty(ref _isOn, value);
		}

		[Ordinal(3)] 
		[RED("weakPersistentEntity")] 
		public CWeakHandle<mpPersistentTestBox> WeakPersistentEntity
		{
			get => GetProperty(ref _weakPersistentEntity);
			set => SetProperty(ref _weakPersistentEntity, value);
		}

		[Ordinal(4)] 
		[RED("weakPersistentEntityComponent")] 
		public CWeakHandle<entIComponent> WeakPersistentEntityComponent
		{
			get => GetProperty(ref _weakPersistentEntityComponent);
			set => SetProperty(ref _weakPersistentEntityComponent, value);
		}

		[Ordinal(5)] 
		[RED("weakDynamicEntity")] 
		public CWeakHandle<gameObject> WeakDynamicEntity
		{
			get => GetProperty(ref _weakDynamicEntity);
			set => SetProperty(ref _weakDynamicEntity, value);
		}

		[Ordinal(6)] 
		[RED("weakDynamicEntityComponent")] 
		public CWeakHandle<entIComponent> WeakDynamicEntityComponent
		{
			get => GetProperty(ref _weakDynamicEntityComponent);
			set => SetProperty(ref _weakDynamicEntityComponent, value);
		}
	}
}
