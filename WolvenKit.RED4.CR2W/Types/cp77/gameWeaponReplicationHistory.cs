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
			get
			{
				if (_weaponSlot == null)
				{
					_weaponSlot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "weaponSlot", cr2w, this);
				}
				return _weaponSlot;
			}
			set
			{
				if (_weaponSlot == value)
				{
					return;
				}
				_weaponSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shots", 8)] 
		public CStatic<gameReplicatedShotData> Shots
		{
			get
			{
				if (_shots == null)
				{
					_shots = (CStatic<gameReplicatedShotData>) CR2WTypeManager.Create("static:8,gameReplicatedShotData", "shots", cr2w, this);
				}
				return _shots;
			}
			set
			{
				if (_shots == value)
				{
					return;
				}
				_shots = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("latestShotId")] 
		public CUInt32 LatestShotId
		{
			get
			{
				if (_latestShotId == null)
				{
					_latestShotId = (CUInt32) CR2WTypeManager.Create("Uint32", "latestShotId", cr2w, this);
				}
				return _latestShotId;
			}
			set
			{
				if (_latestShotId == value)
				{
					return;
				}
				_latestShotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("continuousAttack")] 
		public gameReplicatedContinuousAttack ContinuousAttack
		{
			get
			{
				if (_continuousAttack == null)
				{
					_continuousAttack = (gameReplicatedContinuousAttack) CR2WTypeManager.Create("gameReplicatedContinuousAttack", "continuousAttack", cr2w, this);
				}
				return _continuousAttack;
			}
			set
			{
				if (_continuousAttack == value)
				{
					return;
				}
				_continuousAttack = value;
				PropertySet(this);
			}
		}

		public gameWeaponReplicationHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
