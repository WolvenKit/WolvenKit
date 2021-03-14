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
			get
			{
				if (_isOn == null)
				{
					_isOn = (CBool) CR2WTypeManager.Create("Bool", "isOn", cr2w, this);
				}
				return _isOn;
			}
			set
			{
				if (_isOn == value)
				{
					return;
				}
				_isOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isShooting")] 
		public CBool IsShooting
		{
			get
			{
				if (_isShooting == null)
				{
					_isShooting = (CBool) CR2WTypeManager.Create("Bool", "isShooting", cr2w, this);
				}
				return _isShooting;
			}
			set
			{
				if (_isShooting == value)
				{
					return;
				}
				_isShooting = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get
			{
				if (_isDead == null)
				{
					_isDead = (CBool) CR2WTypeManager.Create("Bool", "isDead", cr2w, this);
				}
				return _isDead;
			}
			set
			{
				if (_isDead == value)
				{
					return;
				}
				_isDead = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("health")] 
		public CFloat Health
		{
			get
			{
				if (_health == null)
				{
					_health = (CFloat) CR2WTypeManager.Create("Float", "health", cr2w, this);
				}
				return _health;
			}
			set
			{
				if (_health == value)
				{
					return;
				}
				_health = value;
				PropertySet(this);
			}
		}

		public SecurityTurretReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
