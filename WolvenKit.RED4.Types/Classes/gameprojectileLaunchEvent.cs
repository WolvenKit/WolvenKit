using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileLaunchEvent : redEvent
	{
		private gameprojectileLaunchParams _launchParams;
		private CWeakHandle<gameObject> _owner;
		private CWeakHandle<gameObject> _weapon;
		private gameprojectileWeaponParams _projectileParams;

		[Ordinal(0)] 
		[RED("launchParams")] 
		public gameprojectileLaunchParams LaunchParams
		{
			get => GetProperty(ref _launchParams);
			set => SetProperty(ref _launchParams, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
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
