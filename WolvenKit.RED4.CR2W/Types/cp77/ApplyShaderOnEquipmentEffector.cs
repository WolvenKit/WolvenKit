using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderOnEquipmentEffector : gameEffector
	{
		private CArray<wCHandle<gameItemObject>> _items;
		private CArray<CHandle<gameEffectInstance>> _effects;
		private CString _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CHandle<gameEffectInstance> _effectInstance;
		private wCHandle<gameObject> _owner;
		private CHandle<gameEffectInstance> _ownerEffect;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<wCHandle<gameItemObject>> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<wCHandle<gameItemObject>>) CR2WTypeManager.Create("array:whandle:gameItemObject", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<CHandle<gameEffectInstance>> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<CHandle<gameEffectInstance>>) CR2WTypeManager.Create("array:handle:gameEffectInstance", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrideMaterialName")] 
		public CString OverrideMaterialName
		{
			get
			{
				if (_overrideMaterialName == null)
				{
					_overrideMaterialName = (CString) CR2WTypeManager.Create("String", "overrideMaterialName", cr2w, this);
				}
				return _overrideMaterialName;
			}
			set
			{
				if (_overrideMaterialName == value)
				{
					return;
				}
				_overrideMaterialName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("overrideMaterialTag")] 
		public CName OverrideMaterialTag
		{
			get
			{
				if (_overrideMaterialTag == null)
				{
					_overrideMaterialTag = (CName) CR2WTypeManager.Create("CName", "overrideMaterialTag", cr2w, this);
				}
				return _overrideMaterialTag;
			}
			set
			{
				if (_overrideMaterialTag == value)
				{
					return;
				}
				_overrideMaterialTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get
			{
				if (_effectInstance == null)
				{
					_effectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "effectInstance", cr2w, this);
				}
				return _effectInstance;
			}
			set
			{
				if (_effectInstance == value)
				{
					return;
				}
				_effectInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ownerEffect")] 
		public CHandle<gameEffectInstance> OwnerEffect
		{
			get
			{
				if (_ownerEffect == null)
				{
					_ownerEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "ownerEffect", cr2w, this);
				}
				return _ownerEffect;
			}
			set
			{
				if (_ownerEffect == value)
				{
					return;
				}
				_ownerEffect = value;
				PropertySet(this);
			}
		}

		public ApplyShaderOnEquipmentEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
