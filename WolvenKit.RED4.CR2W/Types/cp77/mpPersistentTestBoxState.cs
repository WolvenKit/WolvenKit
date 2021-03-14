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
			get
			{
				if (_isOn == null)
				{
					_isOn = (CBool) CR2WTypeManager.Create("Bool", "isOn", cr2w, this);
				}
				return _isOn;
			}
			set
			{
				if (_isOn == value)
				{
					return;
				}
				_isOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weakPersistentEntity")] 
		public wCHandle<mpPersistentTestBox> WeakPersistentEntity
		{
			get
			{
				if (_weakPersistentEntity == null)
				{
					_weakPersistentEntity = (wCHandle<mpPersistentTestBox>) CR2WTypeManager.Create("whandle:mpPersistentTestBox", "weakPersistentEntity", cr2w, this);
				}
				return _weakPersistentEntity;
			}
			set
			{
				if (_weakPersistentEntity == value)
				{
					return;
				}
				_weakPersistentEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weakPersistentEntityComponent")] 
		public wCHandle<entIComponent> WeakPersistentEntityComponent
		{
			get
			{
				if (_weakPersistentEntityComponent == null)
				{
					_weakPersistentEntityComponent = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "weakPersistentEntityComponent", cr2w, this);
				}
				return _weakPersistentEntityComponent;
			}
			set
			{
				if (_weakPersistentEntityComponent == value)
				{
					return;
				}
				_weakPersistentEntityComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("weakDynamicEntity")] 
		public wCHandle<gameObject> WeakDynamicEntity
		{
			get
			{
				if (_weakDynamicEntity == null)
				{
					_weakDynamicEntity = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "weakDynamicEntity", cr2w, this);
				}
				return _weakDynamicEntity;
			}
			set
			{
				if (_weakDynamicEntity == value)
				{
					return;
				}
				_weakDynamicEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("weakDynamicEntityComponent")] 
		public wCHandle<entIComponent> WeakDynamicEntityComponent
		{
			get
			{
				if (_weakDynamicEntityComponent == null)
				{
					_weakDynamicEntityComponent = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "weakDynamicEntityComponent", cr2w, this);
				}
				return _weakDynamicEntityComponent;
			}
			set
			{
				if (_weakDynamicEntityComponent == value)
				{
					return;
				}
				_weakDynamicEntityComponent = value;
				PropertySet(this);
			}
		}

		public mpPersistentTestBoxState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
