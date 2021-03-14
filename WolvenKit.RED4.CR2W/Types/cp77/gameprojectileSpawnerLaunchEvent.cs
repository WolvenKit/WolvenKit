using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnerLaunchEvent : redEvent
	{
		private gameprojectileLaunchParams _launchParams;
		private CName _templateName;
		private wCHandle<gameObject> _owner;
		private gameprojectileWeaponParams _projectileParams;

		[Ordinal(0)] 
		[RED("launchParams")] 
		public gameprojectileLaunchParams LaunchParams
		{
			get
			{
				if (_launchParams == null)
				{
					_launchParams = (gameprojectileLaunchParams) CR2WTypeManager.Create("gameprojectileLaunchParams", "launchParams", cr2w, this);
				}
				return _launchParams;
			}
			set
			{
				if (_launchParams == value)
				{
					return;
				}
				_launchParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("templateName")] 
		public CName TemplateName
		{
			get
			{
				if (_templateName == null)
				{
					_templateName = (CName) CR2WTypeManager.Create("CName", "templateName", cr2w, this);
				}
				return _templateName;
			}
			set
			{
				if (_templateName == value)
				{
					return;
				}
				_templateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("projectileParams")] 
		public gameprojectileWeaponParams ProjectileParams
		{
			get
			{
				if (_projectileParams == null)
				{
					_projectileParams = (gameprojectileWeaponParams) CR2WTypeManager.Create("gameprojectileWeaponParams", "projectileParams", cr2w, this);
				}
				return _projectileParams;
			}
			set
			{
				if (_projectileParams == value)
				{
					return;
				}
				_projectileParams = value;
				PropertySet(this);
			}
		}

		public gameprojectileSpawnerLaunchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
