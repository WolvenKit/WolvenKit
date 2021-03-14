using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityTurbulize : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _scale;
		private CHandle<IEvaluatorFloat> _timelifeLimit;
		private CFloat _noiseInterval;
		private CFloat _duration;
		private CBool _worldSpace;

		[Ordinal(4)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timelifeLimit")] 
		public CHandle<IEvaluatorFloat> TimelifeLimit
		{
			get
			{
				if (_timelifeLimit == null)
				{
					_timelifeLimit = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "timelifeLimit", cr2w, this);
				}
				return _timelifeLimit;
			}
			set
			{
				if (_timelifeLimit == value)
				{
					return;
				}
				_timelifeLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("noiseInterval")] 
		public CFloat NoiseInterval
		{
			get
			{
				if (_noiseInterval == null)
				{
					_noiseInterval = (CFloat) CR2WTypeManager.Create("Float", "noiseInterval", cr2w, this);
				}
				return _noiseInterval;
			}
			set
			{
				if (_noiseInterval == value)
				{
					return;
				}
				_noiseInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("worldSpace")] 
		public CBool WorldSpace
		{
			get
			{
				if (_worldSpace == null)
				{
					_worldSpace = (CBool) CR2WTypeManager.Create("Bool", "worldSpace", cr2w, this);
				}
				return _worldSpace;
			}
			set
			{
				if (_worldSpace == value)
				{
					return;
				}
				_worldSpace = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorVelocityTurbulize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
