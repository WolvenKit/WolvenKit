using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnerAttachExistingEvent : redEvent
	{
		private wCHandle<gameObject> _projectile;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("projectile")] 
		public wCHandle<gameObject> Projectile
		{
			get
			{
				if (_projectile == null)
				{
					_projectile = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "projectile", cr2w, this);
				}
				return _projectile;
			}
			set
			{
				if (_projectile == value)
				{
					return;
				}
				_projectile = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public gameprojectileSpawnerAttachExistingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
