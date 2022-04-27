using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWeaponReplicationHistory : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weaponSlot")] 
		public TweakDBID WeaponSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("shots", 8)] 
		public CStatic<gameReplicatedShotData> Shots
		{
			get => GetPropertyValue<CStatic<gameReplicatedShotData>>();
			set => SetPropertyValue<CStatic<gameReplicatedShotData>>(value);
		}

		[Ordinal(2)] 
		[RED("latestShotId")] 
		public CUInt32 LatestShotId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("continuousAttack")] 
		public gameReplicatedContinuousAttack ContinuousAttack
		{
			get => GetPropertyValue<gameReplicatedContinuousAttack>();
			set => SetPropertyValue<gameReplicatedContinuousAttack>(value);
		}

		public gameWeaponReplicationHistory()
		{
			Shots = new(0);
			LatestShotId = 8;
			ContinuousAttack = new() { StartTimeStamp = new() { MilliSecs = 18446744073709551615 }, StopTimeStamp = new() { MilliSecs = 18446744073709551615 } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
