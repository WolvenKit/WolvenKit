using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileSpawnerLaunchEvent : redEvent
	{
		private gameprojectileLaunchParams _launchParams;
		private CName _templateName;
		private CWeakHandle<gameObject> _owner;
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
		public CWeakHandle<gameObject> Owner
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
	}
}
