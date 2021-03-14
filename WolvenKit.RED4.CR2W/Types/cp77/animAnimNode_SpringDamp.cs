using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SpringDamp : animAnimNode_FloatValue
	{
		private CFloat _massFactor;
		private CFloat _springFactor;
		private CFloat _dampFactor;
		private CBool _startFromDefaultValue;
		private CFloat _defaultInitialValue;
		private CBool _wrapAroundRange;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private CFloat _timeStep;
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("massFactor")] 
		public CFloat MassFactor
		{
			get
			{
				if (_massFactor == null)
				{
					_massFactor = (CFloat) CR2WTypeManager.Create("Float", "massFactor", cr2w, this);
				}
				return _massFactor;
			}
			set
			{
				if (_massFactor == value)
				{
					return;
				}
				_massFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("springFactor")] 
		public CFloat SpringFactor
		{
			get
			{
				if (_springFactor == null)
				{
					_springFactor = (CFloat) CR2WTypeManager.Create("Float", "springFactor", cr2w, this);
				}
				return _springFactor;
			}
			set
			{
				if (_springFactor == value)
				{
					return;
				}
				_springFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("dampFactor")] 
		public CFloat DampFactor
		{
			get
			{
				if (_dampFactor == null)
				{
					_dampFactor = (CFloat) CR2WTypeManager.Create("Float", "dampFactor", cr2w, this);
				}
				return _dampFactor;
			}
			set
			{
				if (_dampFactor == value)
				{
					return;
				}
				_dampFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get
			{
				if (_startFromDefaultValue == null)
				{
					_startFromDefaultValue = (CBool) CR2WTypeManager.Create("Bool", "startFromDefaultValue", cr2w, this);
				}
				return _startFromDefaultValue;
			}
			set
			{
				if (_startFromDefaultValue == value)
				{
					return;
				}
				_startFromDefaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("defaultInitialValue")] 
		public CFloat DefaultInitialValue
		{
			get
			{
				if (_defaultInitialValue == null)
				{
					_defaultInitialValue = (CFloat) CR2WTypeManager.Create("Float", "defaultInitialValue", cr2w, this);
				}
				return _defaultInitialValue;
			}
			set
			{
				if (_defaultInitialValue == value)
				{
					return;
				}
				_defaultInitialValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("wrapAroundRange")] 
		public CBool WrapAroundRange
		{
			get
			{
				if (_wrapAroundRange == null)
				{
					_wrapAroundRange = (CBool) CR2WTypeManager.Create("Bool", "wrapAroundRange", cr2w, this);
				}
				return _wrapAroundRange;
			}
			set
			{
				if (_wrapAroundRange == value)
				{
					return;
				}
				_wrapAroundRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get
			{
				if (_rangeMin == null)
				{
					_rangeMin = (CFloat) CR2WTypeManager.Create("Float", "rangeMin", cr2w, this);
				}
				return _rangeMin;
			}
			set
			{
				if (_rangeMin == value)
				{
					return;
				}
				_rangeMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get
			{
				if (_rangeMax == null)
				{
					_rangeMax = (CFloat) CR2WTypeManager.Create("Float", "rangeMax", cr2w, this);
				}
				return _rangeMax;
			}
			set
			{
				if (_rangeMax == value)
				{
					return;
				}
				_rangeMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("timeStep")] 
		public CFloat TimeStep
		{
			get
			{
				if (_timeStep == null)
				{
					_timeStep = (CFloat) CR2WTypeManager.Create("Float", "timeStep", cr2w, this);
				}
				return _timeStep;
			}
			set
			{
				if (_timeStep == value)
				{
					return;
				}
				_timeStep = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
