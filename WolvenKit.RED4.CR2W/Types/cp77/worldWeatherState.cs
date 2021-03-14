using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWeatherState : CVariable
	{
		private curveData<CFloat> _probability;
		private curveData<CFloat> _minDuration;
		private curveData<CFloat> _maxDuration;
		private curveData<CFloat> _transitionDuration;
		private rRef<worldEnvironmentAreaParameters> _environmentAreaParameters;
		private raRef<worldEffect> _effect;
		private CName _name;

		[Ordinal(0)] 
		[RED("probability")] 
		public curveData<CFloat> Probability
		{
			get
			{
				if (_probability == null)
				{
					_probability = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "probability", cr2w, this);
				}
				return _probability;
			}
			set
			{
				if (_probability == value)
				{
					return;
				}
				_probability = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("minDuration")] 
		public curveData<CFloat> MinDuration
		{
			get
			{
				if (_minDuration == null)
				{
					_minDuration = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "minDuration", cr2w, this);
				}
				return _minDuration;
			}
			set
			{
				if (_minDuration == value)
				{
					return;
				}
				_minDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxDuration")] 
		public curveData<CFloat> MaxDuration
		{
			get
			{
				if (_maxDuration == null)
				{
					_maxDuration = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "maxDuration", cr2w, this);
				}
				return _maxDuration;
			}
			set
			{
				if (_maxDuration == value)
				{
					return;
				}
				_maxDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitionDuration")] 
		public curveData<CFloat> TransitionDuration
		{
			get
			{
				if (_transitionDuration == null)
				{
					_transitionDuration = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "transitionDuration", cr2w, this);
				}
				return _transitionDuration;
			}
			set
			{
				if (_transitionDuration == value)
				{
					return;
				}
				_transitionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("environmentAreaParameters")] 
		public rRef<worldEnvironmentAreaParameters> EnvironmentAreaParameters
		{
			get
			{
				if (_environmentAreaParameters == null)
				{
					_environmentAreaParameters = (rRef<worldEnvironmentAreaParameters>) CR2WTypeManager.Create("rRef:worldEnvironmentAreaParameters", "environmentAreaParameters", cr2w, this);
				}
				return _environmentAreaParameters;
			}
			set
			{
				if (_environmentAreaParameters == value)
				{
					return;
				}
				_environmentAreaParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		public worldWeatherState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
