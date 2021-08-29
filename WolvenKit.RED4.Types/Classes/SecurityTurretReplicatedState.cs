using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityTurretReplicatedState : gameDeviceReplicatedState
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
	}
}
