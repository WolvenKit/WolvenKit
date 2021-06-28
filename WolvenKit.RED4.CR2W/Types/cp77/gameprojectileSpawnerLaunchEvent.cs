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
			get => GetProperty(ref _launchParams);
			set => SetProperty(ref _launchParams, value);
		}

		[Ordinal(1)] 
		[RED("templateName")] 
		public CName TemplateName
		{
			get => GetProperty(ref _templateName);
			set => SetProperty(ref _templateName, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("projectileParams")] 
		public gameprojectileWeaponParams ProjectileParams
		{
			get => GetProperty(ref _projectileParams);
			set => SetProperty(ref _projectileParams, value);
		}

		public gameprojectileSpawnerLaunchEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
