using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSliderController : inkWidgetLogicController
	{
		private inkWidgetReference _slidingAreaRef;
		private inkWidgetReference _handleRef;
		private inkWidgetReference _nextRef;
		private inkWidgetReference _priorRef;
		private CEnum<inkESliderDirection> _direction;
		private CBool _autoSizeHandle;
		private CFloat _minHandleSize;
		private CFloat _maxHandleSize;
		private CFloat _percentHandleSize;
		private CFloat _currentProgress;
		private CFloat _minimumValue;
		private CFloat _maximumValue;
		private CFloat _step;
		private inkSliderControllerInputCallback _sliderInput;
		private inkSliderControllerValueChangeCallback _sliderValueChanged;
		private inkSliderControllerHandleReleasedCallback _sliderHandleReleased;

		[Ordinal(1)] 
		[RED("slidingAreaRef")] 
		public inkWidgetReference SlidingAreaRef
		{
			get
			{
				if (_slidingAreaRef == null)
				{
					_slidingAreaRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slidingAreaRef", cr2w, this);
				}
				return _slidingAreaRef;
			}
			set
			{
				if (_slidingAreaRef == value)
				{
					return;
				}
				_slidingAreaRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("handleRef")] 
		public inkWidgetReference HandleRef
		{
			get
			{
				if (_handleRef == null)
				{
					_handleRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "handleRef", cr2w, this);
				}
				return _handleRef;
			}
			set
			{
				if (_handleRef == value)
				{
					return;
				}
				_handleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("nextRef")] 
		public inkWidgetReference NextRef
		{
			get
			{
				if (_nextRef == null)
				{
					_nextRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nextRef", cr2w, this);
				}
				return _nextRef;
			}
			set
			{
				if (_nextRef == value)
				{
					return;
				}
				_nextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("priorRef")] 
		public inkWidgetReference PriorRef
		{
			get
			{
				if (_priorRef == null)
				{
					_priorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "priorRef", cr2w, this);
				}
				return _priorRef;
			}
			set
			{
				if (_priorRef == value)
				{
					return;
				}
				_priorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("direction")] 
		public CEnum<inkESliderDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<inkESliderDirection>) CR2WTypeManager.Create("inkESliderDirection", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("autoSizeHandle")] 
		public CBool AutoSizeHandle
		{
			get
			{
				if (_autoSizeHandle == null)
				{
					_autoSizeHandle = (CBool) CR2WTypeManager.Create("Bool", "autoSizeHandle", cr2w, this);
				}
				return _autoSizeHandle;
			}
			set
			{
				if (_autoSizeHandle == value)
				{
					return;
				}
				_autoSizeHandle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("minHandleSize")] 
		public CFloat MinHandleSize
		{
			get
			{
				if (_minHandleSize == null)
				{
					_minHandleSize = (CFloat) CR2WTypeManager.Create("Float", "minHandleSize", cr2w, this);
				}
				return _minHandleSize;
			}
			set
			{
				if (_minHandleSize == value)
				{
					return;
				}
				_minHandleSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("maxHandleSize")] 
		public CFloat MaxHandleSize
		{
			get
			{
				if (_maxHandleSize == null)
				{
					_maxHandleSize = (CFloat) CR2WTypeManager.Create("Float", "maxHandleSize", cr2w, this);
				}
				return _maxHandleSize;
			}
			set
			{
				if (_maxHandleSize == value)
				{
					return;
				}
				_maxHandleSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("percentHandleSize")] 
		public CFloat PercentHandleSize
		{
			get
			{
				if (_percentHandleSize == null)
				{
					_percentHandleSize = (CFloat) CR2WTypeManager.Create("Float", "percentHandleSize", cr2w, this);
				}
				return _percentHandleSize;
			}
			set
			{
				if (_percentHandleSize == value)
				{
					return;
				}
				_percentHandleSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentProgress")] 
		public CFloat CurrentProgress
		{
			get
			{
				if (_currentProgress == null)
				{
					_currentProgress = (CFloat) CR2WTypeManager.Create("Float", "currentProgress", cr2w, this);
				}
				return _currentProgress;
			}
			set
			{
				if (_currentProgress == value)
				{
					return;
				}
				_currentProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("minimumValue")] 
		public CFloat MinimumValue
		{
			get
			{
				if (_minimumValue == null)
				{
					_minimumValue = (CFloat) CR2WTypeManager.Create("Float", "minimumValue", cr2w, this);
				}
				return _minimumValue;
			}
			set
			{
				if (_minimumValue == value)
				{
					return;
				}
				_minimumValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("maximumValue")] 
		public CFloat MaximumValue
		{
			get
			{
				if (_maximumValue == null)
				{
					_maximumValue = (CFloat) CR2WTypeManager.Create("Float", "maximumValue", cr2w, this);
				}
				return _maximumValue;
			}
			set
			{
				if (_maximumValue == value)
				{
					return;
				}
				_maximumValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("step")] 
		public CFloat Step
		{
			get
			{
				if (_step == null)
				{
					_step = (CFloat) CR2WTypeManager.Create("Float", "step", cr2w, this);
				}
				return _step;
			}
			set
			{
				if (_step == value)
				{
					return;
				}
				_step = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("SliderInput")] 
		public inkSliderControllerInputCallback SliderInput
		{
			get
			{
				if (_sliderInput == null)
				{
					_sliderInput = (inkSliderControllerInputCallback) CR2WTypeManager.Create("inkSliderControllerInputCallback", "SliderInput", cr2w, this);
				}
				return _sliderInput;
			}
			set
			{
				if (_sliderInput == value)
				{
					return;
				}
				_sliderInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("SliderValueChanged")] 
		public inkSliderControllerValueChangeCallback SliderValueChanged
		{
			get
			{
				if (_sliderValueChanged == null)
				{
					_sliderValueChanged = (inkSliderControllerValueChangeCallback) CR2WTypeManager.Create("inkSliderControllerValueChangeCallback", "SliderValueChanged", cr2w, this);
				}
				return _sliderValueChanged;
			}
			set
			{
				if (_sliderValueChanged == value)
				{
					return;
				}
				_sliderValueChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("SliderHandleReleased")] 
		public inkSliderControllerHandleReleasedCallback SliderHandleReleased
		{
			get
			{
				if (_sliderHandleReleased == null)
				{
					_sliderHandleReleased = (inkSliderControllerHandleReleasedCallback) CR2WTypeManager.Create("inkSliderControllerHandleReleasedCallback", "SliderHandleReleased", cr2w, this);
				}
				return _sliderHandleReleased;
			}
			set
			{
				if (_sliderHandleReleased == value)
				{
					return;
				}
				_sliderHandleReleased = value;
				PropertySet(this);
			}
		}

		public inkSliderController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
