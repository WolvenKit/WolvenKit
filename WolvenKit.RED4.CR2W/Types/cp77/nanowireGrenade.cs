using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class nanowireGrenade : BaseProjectile
	{
		private CFloat _countTime;
		private CFloat _timeToActivation;
		private CFloat _energyLossFactor;
		private CFloat _startVelocity;
		private CFloat _grenadeLifetime;
		private CFloat _gravitySimulation;
		private CName _trailEffectName;
		private CBool _alive;

		[Ordinal(51)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get
			{
				if (_countTime == null)
				{
					_countTime = (CFloat) CR2WTypeManager.Create("Float", "countTime", cr2w, this);
				}
				return _countTime;
			}
			set
			{
				if (_countTime == value)
				{
					return;
				}
				_countTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("timeToActivation")] 
		public CFloat TimeToActivation
		{
			get
			{
				if (_timeToActivation == null)
				{
					_timeToActivation = (CFloat) CR2WTypeManager.Create("Float", "timeToActivation", cr2w, this);
				}
				return _timeToActivation;
			}
			set
			{
				if (_timeToActivation == value)
				{
					return;
				}
				_timeToActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("energyLossFactor")] 
		public CFloat EnergyLossFactor
		{
			get
			{
				if (_energyLossFactor == null)
				{
					_energyLossFactor = (CFloat) CR2WTypeManager.Create("Float", "energyLossFactor", cr2w, this);
				}
				return _energyLossFactor;
			}
			set
			{
				if (_energyLossFactor == value)
				{
					return;
				}
				_energyLossFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get
			{
				if (_startVelocity == null)
				{
					_startVelocity = (CFloat) CR2WTypeManager.Create("Float", "startVelocity", cr2w, this);
				}
				return _startVelocity;
			}
			set
			{
				if (_startVelocity == value)
				{
					return;
				}
				_startVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("grenadeLifetime")] 
		public CFloat GrenadeLifetime
		{
			get
			{
				if (_grenadeLifetime == null)
				{
					_grenadeLifetime = (CFloat) CR2WTypeManager.Create("Float", "grenadeLifetime", cr2w, this);
				}
				return _grenadeLifetime;
			}
			set
			{
				if (_grenadeLifetime == value)
				{
					return;
				}
				_grenadeLifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("gravitySimulation")] 
		public CFloat GravitySimulation
		{
			get
			{
				if (_gravitySimulation == null)
				{
					_gravitySimulation = (CFloat) CR2WTypeManager.Create("Float", "gravitySimulation", cr2w, this);
				}
				return _gravitySimulation;
			}
			set
			{
				if (_gravitySimulation == value)
				{
					return;
				}
				_gravitySimulation = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("trailEffectName")] 
		public CName TrailEffectName
		{
			get
			{
				if (_trailEffectName == null)
				{
					_trailEffectName = (CName) CR2WTypeManager.Create("CName", "trailEffectName", cr2w, this);
				}
				return _trailEffectName;
			}
			set
			{
				if (_trailEffectName == value)
				{
					return;
				}
				_trailEffectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("alive")] 
		public CBool Alive
		{
			get
			{
				if (_alive == null)
				{
					_alive = (CBool) CR2WTypeManager.Create("Bool", "alive", cr2w, this);
				}
				return _alive;
			}
			set
			{
				if (_alive == value)
				{
					return;
				}
				_alive = value;
				PropertySet(this);
			}
		}

		public nanowireGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
