using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowableWeaponObject : gameweaponObject
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private wCHandle<gameObject> _weaponOwner;

		[Ordinal(57)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get
			{
				if (_projectileComponent == null)
				{
					_projectileComponent = (CHandle<gameprojectileComponent>) CR2WTypeManager.Create("handle:gameprojectileComponent", "projectileComponent", cr2w, this);
				}
				return _projectileComponent;
			}
			set
			{
				if (_projectileComponent == value)
				{
					return;
				}
				_projectileComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("weaponOwner")] 
		public wCHandle<gameObject> WeaponOwner
		{
			get
			{
				if (_weaponOwner == null)
				{
					_weaponOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "weaponOwner", cr2w, this);
				}
				return _weaponOwner;
			}
			set
			{
				if (_weaponOwner == value)
				{
					return;
				}
				_weaponOwner = value;
				PropertySet(this);
			}
		}

		public ThrowableWeaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
