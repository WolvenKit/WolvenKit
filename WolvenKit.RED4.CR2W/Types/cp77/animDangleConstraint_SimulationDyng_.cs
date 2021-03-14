using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_SimulationDyng_ : animDangleConstraint_Simulation
	{
		private CBool _hACK_checkDangleTeleport;
		private CFloat _substepTime;
		private CUInt32 _solverIterations;
		private animDyngParticlesContainer _particlesContainer;
		private CHandle<animIDyngConstraint> _dyngConstraint;

		[Ordinal(13)] 
		[RED("HACK_checkDangleTeleport")] 
		public CBool HACK_checkDangleTeleport
		{
			get
			{
				if (_hACK_checkDangleTeleport == null)
				{
					_hACK_checkDangleTeleport = (CBool) CR2WTypeManager.Create("Bool", "HACK_checkDangleTeleport", cr2w, this);
				}
				return _hACK_checkDangleTeleport;
			}
			set
			{
				if (_hACK_checkDangleTeleport == value)
				{
					return;
				}
				_hACK_checkDangleTeleport = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("substepTime")] 
		public CFloat SubstepTime
		{
			get
			{
				if (_substepTime == null)
				{
					_substepTime = (CFloat) CR2WTypeManager.Create("Float", "substepTime", cr2w, this);
				}
				return _substepTime;
			}
			set
			{
				if (_substepTime == value)
				{
					return;
				}
				_substepTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("solverIterations")] 
		public CUInt32 SolverIterations
		{
			get
			{
				if (_solverIterations == null)
				{
					_solverIterations = (CUInt32) CR2WTypeManager.Create("Uint32", "solverIterations", cr2w, this);
				}
				return _solverIterations;
			}
			set
			{
				if (_solverIterations == value)
				{
					return;
				}
				_solverIterations = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("particlesContainer")] 
		public animDyngParticlesContainer ParticlesContainer
		{
			get
			{
				if (_particlesContainer == null)
				{
					_particlesContainer = (animDyngParticlesContainer) CR2WTypeManager.Create("animDyngParticlesContainer", "particlesContainer", cr2w, this);
				}
				return _particlesContainer;
			}
			set
			{
				if (_particlesContainer == value)
				{
					return;
				}
				_particlesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("dyngConstraint")] 
		public CHandle<animIDyngConstraint> DyngConstraint
		{
			get
			{
				if (_dyngConstraint == null)
				{
					_dyngConstraint = (CHandle<animIDyngConstraint>) CR2WTypeManager.Create("handle:animIDyngConstraint", "dyngConstraint", cr2w, this);
				}
				return _dyngConstraint;
			}
			set
			{
				if (_dyngConstraint == value)
				{
					return;
				}
				_dyngConstraint = value;
				PropertySet(this);
			}
		}

		public animDangleConstraint_SimulationDyng_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
