using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSetUpEvent : redEvent
	{
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _weapon;
		private CHandle<gameprojectileTrajectoryParams> _trajectoryParams;
		private CFloat _lerpMultiplier;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(2)] 
		[RED("trajectoryParams")] 
		public CHandle<gameprojectileTrajectoryParams> TrajectoryParams
		{
			get => GetProperty(ref _trajectoryParams);
			set => SetProperty(ref _trajectoryParams, value);
		}

		[Ordinal(3)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get => GetProperty(ref _lerpMultiplier);
			set => SetProperty(ref _lerpMultiplier, value);
		}

		public gameprojectileSetUpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
