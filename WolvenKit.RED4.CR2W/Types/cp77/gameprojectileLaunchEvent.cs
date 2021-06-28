using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLaunchEvent : redEvent
	{
		private gameprojectileLaunchParams _launchParams;
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _weapon;
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
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
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

		public gameprojectileLaunchEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
