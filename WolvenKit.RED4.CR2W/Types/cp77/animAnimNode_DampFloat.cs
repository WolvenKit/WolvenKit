using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampFloat : animAnimNode_FloatValue
	{
		private CFloat _defaultIncreaseSpeed;
		private CFloat _defaultDecreaseSpeed;
		private CBool _startFromDefaultValue;
		private CFloat _defaultInitialValue;
		private CBool _wrapAroundRange;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private animFloatLink _inputNode;
		private animFloatLink _increaseSpeedNode;
		private animFloatLink _decreaseSpeedNode;

		[Ordinal(11)] 
		[RED("defaultIncreaseSpeed")] 
		public CFloat DefaultIncreaseSpeed
		{
			get
			{
				if (_defaultIncreaseSpeed == null)
				{
					_defaultIncreaseSpeed = (CFloat) CR2WTypeManager.Create("Float", "defaultIncreaseSpeed", cr2w, this);
				}
				return _defaultIncreaseSpeed;
			}
			set
			{
				if (_defaultIncreaseSpeed == value)
				{
					return;
				}
				_defaultIncreaseSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("defaultDecreaseSpeed")] 
		public CFloat DefaultDecreaseSpeed
		{
			get
			{
				if (_defaultDecreaseSpeed == null)
				{
					_defaultDecreaseSpeed = (CFloat) CR2WTypeManager.Create("Float", "defaultDecreaseSpeed", cr2w, this);
				}
				return _defaultDecreaseSpeed;
			}
			set
			{
				if (_defaultDecreaseSpeed == value)
				{
					return;
				}
				_defaultDecreaseSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("increaseSpeedNode")] 
		public animFloatLink IncreaseSpeedNode
		{
			get
			{
				if (_increaseSpeedNode == null)
				{
					_increaseSpeedNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "increaseSpeedNode", cr2w, this);
				}
				return _increaseSpeedNode;
			}
			set
			{
				if (_increaseSpeedNode == value)
				{
					return;
				}
				_increaseSpeedNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("decreaseSpeedNode")] 
		public animFloatLink DecreaseSpeedNode
		{
			get
			{
				if (_decreaseSpeedNode == null)
				{
					_decreaseSpeedNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "decreaseSpeedNode", cr2w, this);
				}
				return _decreaseSpeedNode;
			}
			set
			{
				if (_decreaseSpeedNode == value)
				{
					return;
				}
				_decreaseSpeedNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_DampFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
