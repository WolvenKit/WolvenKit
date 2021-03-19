using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class mpPersistentTestBoxState : netIEntityState
	{
		private CBool _isOn;
		private wCHandle<mpPersistentTestBox> _weakPersistentEntity;
		private wCHandle<entIComponent> _weakPersistentEntityComponent;
		private wCHandle<gameObject> _weakDynamicEntity;
		private wCHandle<entIComponent> _weakDynamicEntityComponent;

		[Ordinal(2)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetProperty(ref _isOn);
			set => SetProperty(ref _isOn, value);
		}

		[Ordinal(3)] 
		[RED("weakPersistentEntity")] 
		public wCHandle<mpPersistentTestBox> WeakPersistentEntity
		{
			get => GetProperty(ref _weakPersistentEntity);
			set => SetProperty(ref _weakPersistentEntity, value);
		}

		[Ordinal(4)] 
		[RED("weakPersistentEntityComponent")] 
		public wCHandle<entIComponent> WeakPersistentEntityComponent
		{
			get => GetProperty(ref _weakPersistentEntityComponent);
			set => SetProperty(ref _weakPersistentEntityComponent, value);
		}

		[Ordinal(5)] 
		[RED("weakDynamicEntity")] 
		public wCHandle<gameObject> WeakDynamicEntity
		{
			get => GetProperty(ref _weakDynamicEntity);
			set => SetProperty(ref _weakDynamicEntity, value);
		}

		[Ordinal(6)] 
		[RED("weakDynamicEntityComponent")] 
		public wCHandle<entIComponent> WeakDynamicEntityComponent
		{
			get => GetProperty(ref _weakDynamicEntityComponent);
			set => SetProperty(ref _weakDynamicEntityComponent, value);
		}

		public mpPersistentTestBoxState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
