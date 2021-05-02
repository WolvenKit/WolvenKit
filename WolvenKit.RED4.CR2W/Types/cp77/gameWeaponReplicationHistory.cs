using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeaponReplicationHistory : CVariable
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

		public gameWeaponReplicationHistory(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
