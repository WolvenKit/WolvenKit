using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderEffector : gameEffector
	{
		private CName _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CBool _applyToOwner;
		private CBool _applyToWeapon;
		private wCHandle<gameObject> _owner;
		private CArray<wCHandle<gameItemObject>> _ownerWeapons;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("overrideMaterialName")] 
		public CName OverrideMaterialName
		{
			get
			{
				if (_overrideMaterialName == null)
				{
					_overrideMaterialName = (CName) CR2WTypeManager.Create("CName", "overrideMaterialName", cr2w, this);
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("applyToOwner")] 
		public CBool ApplyToOwner
		{
			get
			{
				if (_applyToOwner == null)
				{
					_applyToOwner = (CBool) CR2WTypeManager.Create("Bool", "applyToOwner", cr2w, this);
				}
				return _applyToOwner;
			}
			set
			{
				if (_applyToOwner == value)
				{
					return;
				}
				_applyToOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("applyToWeapon")] 
		public CBool ApplyToWeapon
		{
			get
			{
				if (_applyToWeapon == null)
				{
					_applyToWeapon = (CBool) CR2WTypeManager.Create("Bool", "applyToWeapon", cr2w, this);
				}
				return _applyToWeapon;
			}
			set
			{
				if (_applyToWeapon == value)
				{
					return;
				}
				_applyToWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("ownerWeapons")] 
		public CArray<wCHandle<gameItemObject>> OwnerWeapons
		{
			get
			{
				if (_ownerWeapons == null)
				{
					_ownerWeapons = (CArray<wCHandle<gameItemObject>>) CR2WTypeManager.Create("array:whandle:gameItemObject", "ownerWeapons", cr2w, this);
				}
				return _ownerWeapons;
			}
			set
			{
				if (_ownerWeapons == value)
				{
					return;
				}
				_ownerWeapons = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public ApplyShaderEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
