using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityTurretReplicatedState : gameDeviceReplicatedState
	{
		private CBool _isOn;
		private CBool _isShooting;
		private CBool _isDead;
		private CFloat _health;

		[Ordinal(0)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetProperty(ref _isOn);
			set => SetProperty(ref _isOn, value);
		}

		[Ordinal(1)] 
		[RED("isShooting")] 
		public CBool IsShooting
		{
			get => GetProperty(ref _isShooting);
			set => SetProperty(ref _isShooting, value);
		}

		[Ordinal(2)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(3)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		public SecurityTurretReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
