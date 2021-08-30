using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWeaponReplicationHistory : RedBaseClass
	{
		private TweakDBID _weaponSlot;
		private CStatic<gameReplicatedShotData> _shots;
		private CUInt32 _latestShotId;
		private gameReplicatedContinuousAttack _continuousAttack;

		[Ordinal(0)] 
		[RED("weaponSlot")] 
		public TweakDBID WeaponSlot
		{
			get => GetProperty(ref _weaponSlot);
			set => SetProperty(ref _weaponSlot, value);
		}

		[Ordinal(1)] 
		[RED("shots", 8)] 
		public CStatic<gameReplicatedShotData> Shots
		{
			get => GetProperty(ref _shots);
			set => SetProperty(ref _shots, value);
		}

		[Ordinal(2)] 
		[RED("latestShotId")] 
		public CUInt32 LatestShotId
		{
			get => GetProperty(ref _latestShotId);
			set => SetProperty(ref _latestShotId, value);
		}

		[Ordinal(3)] 
		[RED("continuousAttack")] 
		public gameReplicatedContinuousAttack ContinuousAttack
		{
			get => GetProperty(ref _continuousAttack);
			set => SetProperty(ref _continuousAttack, value);
		}

		public gameWeaponReplicationHistory()
		{
			_latestShotId = 8;
		}
	}
}
