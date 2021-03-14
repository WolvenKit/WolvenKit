using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticParticleNode : worldNode
	{
		private CFloat _emissionRate;
		private raRef<CParticleSystem> _particleSystem;
		private CFloat _forcedAutoHideDistance;
		private CFloat _forcedAutoHideRange;

		[Ordinal(4)] 
		[RED("emissionRate")] 
		public CFloat EmissionRate
		{
			get
			{
				if (_emissionRate == null)
				{
					_emissionRate = (CFloat) CR2WTypeManager.Create("Float", "emissionRate", cr2w, this);
				}
				return _emissionRate;
			}
			set
			{
				if (_emissionRate == value)
				{
					return;
				}
				_emissionRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("particleSystem")] 
		public raRef<CParticleSystem> ParticleSystem
		{
			get
			{
				if (_particleSystem == null)
				{
					_particleSystem = (raRef<CParticleSystem>) CR2WTypeManager.Create("raRef:CParticleSystem", "particleSystem", cr2w, this);
				}
				return _particleSystem;
			}
			set
			{
				if (_particleSystem == value)
				{
					return;
				}
				_particleSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forcedAutoHideDistance")] 
		public CFloat ForcedAutoHideDistance
		{
			get
			{
				if (_forcedAutoHideDistance == null)
				{
					_forcedAutoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "forcedAutoHideDistance", cr2w, this);
				}
				return _forcedAutoHideDistance;
			}
			set
			{
				if (_forcedAutoHideDistance == value)
				{
					return;
				}
				_forcedAutoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("forcedAutoHideRange")] 
		public CFloat ForcedAutoHideRange
		{
			get
			{
				if (_forcedAutoHideRange == null)
				{
					_forcedAutoHideRange = (CFloat) CR2WTypeManager.Create("Float", "forcedAutoHideRange", cr2w, this);
				}
				return _forcedAutoHideRange;
			}
			set
			{
				if (_forcedAutoHideRange == value)
				{
					return;
				}
				_forcedAutoHideRange = value;
				PropertySet(this);
			}
		}

		public worldStaticParticleNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
