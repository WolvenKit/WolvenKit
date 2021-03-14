using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcWeaponSettings : audioWeaponSettings
	{
		private CName _gunChoir;
		private CName _tails;
		private CBool _obstructionEnabled;
		private CBool _occlusionEnabled;
		private CBool _repositionEnabled;
		private CFloat _obstructionChangeTime;
		private CBool _disablePathfinding;
		private CFloat _voiceSwitchCooldown;
		private CName _reloadSound;
		private CName _quickMeleeAttackSound;
		private CName _quickMeleeHitSound;

		[Ordinal(10)] 
		[RED("gunChoir")] 
		public CName GunChoir
		{
			get
			{
				if (_gunChoir == null)
				{
					_gunChoir = (CName) CR2WTypeManager.Create("CName", "gunChoir", cr2w, this);
				}
				return _gunChoir;
			}
			set
			{
				if (_gunChoir == value)
				{
					return;
				}
				_gunChoir = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("tails")] 
		public CName Tails
		{
			get
			{
				if (_tails == null)
				{
					_tails = (CName) CR2WTypeManager.Create("CName", "tails", cr2w, this);
				}
				return _tails;
			}
			set
			{
				if (_tails == value)
				{
					return;
				}
				_tails = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("obstructionEnabled")] 
		public CBool ObstructionEnabled
		{
			get
			{
				if (_obstructionEnabled == null)
				{
					_obstructionEnabled = (CBool) CR2WTypeManager.Create("Bool", "obstructionEnabled", cr2w, this);
				}
				return _obstructionEnabled;
			}
			set
			{
				if (_obstructionEnabled == value)
				{
					return;
				}
				_obstructionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get
			{
				if (_occlusionEnabled == null)
				{
					_occlusionEnabled = (CBool) CR2WTypeManager.Create("Bool", "occlusionEnabled", cr2w, this);
				}
				return _occlusionEnabled;
			}
			set
			{
				if (_occlusionEnabled == value)
				{
					return;
				}
				_occlusionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("repositionEnabled")] 
		public CBool RepositionEnabled
		{
			get
			{
				if (_repositionEnabled == null)
				{
					_repositionEnabled = (CBool) CR2WTypeManager.Create("Bool", "repositionEnabled", cr2w, this);
				}
				return _repositionEnabled;
			}
			set
			{
				if (_repositionEnabled == value)
				{
					return;
				}
				_repositionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get
			{
				if (_obstructionChangeTime == null)
				{
					_obstructionChangeTime = (CFloat) CR2WTypeManager.Create("Float", "obstructionChangeTime", cr2w, this);
				}
				return _obstructionChangeTime;
			}
			set
			{
				if (_obstructionChangeTime == value)
				{
					return;
				}
				_obstructionChangeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("disablePathfinding")] 
		public CBool DisablePathfinding
		{
			get
			{
				if (_disablePathfinding == null)
				{
					_disablePathfinding = (CBool) CR2WTypeManager.Create("Bool", "disablePathfinding", cr2w, this);
				}
				return _disablePathfinding;
			}
			set
			{
				if (_disablePathfinding == value)
				{
					return;
				}
				_disablePathfinding = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("voiceSwitchCooldown")] 
		public CFloat VoiceSwitchCooldown
		{
			get
			{
				if (_voiceSwitchCooldown == null)
				{
					_voiceSwitchCooldown = (CFloat) CR2WTypeManager.Create("Float", "voiceSwitchCooldown", cr2w, this);
				}
				return _voiceSwitchCooldown;
			}
			set
			{
				if (_voiceSwitchCooldown == value)
				{
					return;
				}
				_voiceSwitchCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("reloadSound")] 
		public CName ReloadSound
		{
			get
			{
				if (_reloadSound == null)
				{
					_reloadSound = (CName) CR2WTypeManager.Create("CName", "reloadSound", cr2w, this);
				}
				return _reloadSound;
			}
			set
			{
				if (_reloadSound == value)
				{
					return;
				}
				_reloadSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("quickMeleeAttackSound")] 
		public CName QuickMeleeAttackSound
		{
			get
			{
				if (_quickMeleeAttackSound == null)
				{
					_quickMeleeAttackSound = (CName) CR2WTypeManager.Create("CName", "quickMeleeAttackSound", cr2w, this);
				}
				return _quickMeleeAttackSound;
			}
			set
			{
				if (_quickMeleeAttackSound == value)
				{
					return;
				}
				_quickMeleeAttackSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("quickMeleeHitSound")] 
		public CName QuickMeleeHitSound
		{
			get
			{
				if (_quickMeleeHitSound == null)
				{
					_quickMeleeHitSound = (CName) CR2WTypeManager.Create("CName", "quickMeleeHitSound", cr2w, this);
				}
				return _quickMeleeHitSound;
			}
			set
			{
				if (_quickMeleeHitSound == value)
				{
					return;
				}
				_quickMeleeHitSound = value;
				PropertySet(this);
			}
		}

		public audioNpcWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
