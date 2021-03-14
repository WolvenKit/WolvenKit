using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InterpolatorsShowcaseController : inkWidgetLogicController
	{
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private wCHandle<inkWidget> _overlay;
		private wCHandle<inkWidget> _heightBar;
		private wCHandle<inkWidget> _widthBar;
		private wCHandle<inkWidget> _graphPointer;
		private wCHandle<inkTextWidget> _counterText;
		private wCHandle<inkWidget> _sizeWidget;
		private wCHandle<inkWidget> _rotationWidget;
		private wCHandle<inkWidget> _marginWidget;
		private wCHandle<inkWidget> _colorWidget;
		private CHandle<inkanimDefinition> _sizeAnim;
		private CHandle<inkanimDefinition> _rotationAnim;
		private CHandle<inkanimDefinition> _marginAnim;
		private CHandle<inkanimDefinition> _colorAnim;
		private CHandle<inkanimDefinition> _followTimelineAnim;
		private CHandle<inkanimDefinition> _interpolateAnim;
		private inkMargin _startMargin;
		private CFloat _animLength;
		private CHandle<AnimationsConstructor> _animConstructor;

		[Ordinal(1)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get
			{
				if (_interpolationType == null)
				{
					_interpolationType = (CEnum<inkanimInterpolationType>) CR2WTypeManager.Create("inkanimInterpolationType", "interpolationType", cr2w, this);
				}
				return _interpolationType;
			}
			set
			{
				if (_interpolationType == value)
				{
					return;
				}
				_interpolationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get
			{
				if (_interpolationMode == null)
				{
					_interpolationMode = (CEnum<inkanimInterpolationMode>) CR2WTypeManager.Create("inkanimInterpolationMode", "interpolationMode", cr2w, this);
				}
				return _interpolationMode;
			}
			set
			{
				if (_interpolationMode == value)
				{
					return;
				}
				_interpolationMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("overlay")] 
		public wCHandle<inkWidget> Overlay
		{
			get
			{
				if (_overlay == null)
				{
					_overlay = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "overlay", cr2w, this);
				}
				return _overlay;
			}
			set
			{
				if (_overlay == value)
				{
					return;
				}
				_overlay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("heightBar")] 
		public wCHandle<inkWidget> HeightBar
		{
			get
			{
				if (_heightBar == null)
				{
					_heightBar = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "heightBar", cr2w, this);
				}
				return _heightBar;
			}
			set
			{
				if (_heightBar == value)
				{
					return;
				}
				_heightBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("widthBar")] 
		public wCHandle<inkWidget> WidthBar
		{
			get
			{
				if (_widthBar == null)
				{
					_widthBar = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widthBar", cr2w, this);
				}
				return _widthBar;
			}
			set
			{
				if (_widthBar == value)
				{
					return;
				}
				_widthBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("graphPointer")] 
		public wCHandle<inkWidget> GraphPointer
		{
			get
			{
				if (_graphPointer == null)
				{
					_graphPointer = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "graphPointer", cr2w, this);
				}
				return _graphPointer;
			}
			set
			{
				if (_graphPointer == value)
				{
					return;
				}
				_graphPointer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("counterText")] 
		public wCHandle<inkTextWidget> CounterText
		{
			get
			{
				if (_counterText == null)
				{
					_counterText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "counterText", cr2w, this);
				}
				return _counterText;
			}
			set
			{
				if (_counterText == value)
				{
					return;
				}
				_counterText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sizeWidget")] 
		public wCHandle<inkWidget> SizeWidget
		{
			get
			{
				if (_sizeWidget == null)
				{
					_sizeWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "sizeWidget", cr2w, this);
				}
				return _sizeWidget;
			}
			set
			{
				if (_sizeWidget == value)
				{
					return;
				}
				_sizeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rotationWidget")] 
		public wCHandle<inkWidget> RotationWidget
		{
			get
			{
				if (_rotationWidget == null)
				{
					_rotationWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rotationWidget", cr2w, this);
				}
				return _rotationWidget;
			}
			set
			{
				if (_rotationWidget == value)
				{
					return;
				}
				_rotationWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("marginWidget")] 
		public wCHandle<inkWidget> MarginWidget
		{
			get
			{
				if (_marginWidget == null)
				{
					_marginWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "marginWidget", cr2w, this);
				}
				return _marginWidget;
			}
			set
			{
				if (_marginWidget == value)
				{
					return;
				}
				_marginWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("colorWidget")] 
		public wCHandle<inkWidget> ColorWidget
		{
			get
			{
				if (_colorWidget == null)
				{
					_colorWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "colorWidget", cr2w, this);
				}
				return _colorWidget;
			}
			set
			{
				if (_colorWidget == value)
				{
					return;
				}
				_colorWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sizeAnim")] 
		public CHandle<inkanimDefinition> SizeAnim
		{
			get
			{
				if (_sizeAnim == null)
				{
					_sizeAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "sizeAnim", cr2w, this);
				}
				return _sizeAnim;
			}
			set
			{
				if (_sizeAnim == value)
				{
					return;
				}
				_sizeAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rotationAnim")] 
		public CHandle<inkanimDefinition> RotationAnim
		{
			get
			{
				if (_rotationAnim == null)
				{
					_rotationAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "rotationAnim", cr2w, this);
				}
				return _rotationAnim;
			}
			set
			{
				if (_rotationAnim == value)
				{
					return;
				}
				_rotationAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("marginAnim")] 
		public CHandle<inkanimDefinition> MarginAnim
		{
			get
			{
				if (_marginAnim == null)
				{
					_marginAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "marginAnim", cr2w, this);
				}
				return _marginAnim;
			}
			set
			{
				if (_marginAnim == value)
				{
					return;
				}
				_marginAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("colorAnim")] 
		public CHandle<inkanimDefinition> ColorAnim
		{
			get
			{
				if (_colorAnim == null)
				{
					_colorAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "colorAnim", cr2w, this);
				}
				return _colorAnim;
			}
			set
			{
				if (_colorAnim == value)
				{
					return;
				}
				_colorAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("followTimelineAnim")] 
		public CHandle<inkanimDefinition> FollowTimelineAnim
		{
			get
			{
				if (_followTimelineAnim == null)
				{
					_followTimelineAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "followTimelineAnim", cr2w, this);
				}
				return _followTimelineAnim;
			}
			set
			{
				if (_followTimelineAnim == value)
				{
					return;
				}
				_followTimelineAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("interpolateAnim")] 
		public CHandle<inkanimDefinition> InterpolateAnim
		{
			get
			{
				if (_interpolateAnim == null)
				{
					_interpolateAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "interpolateAnim", cr2w, this);
				}
				return _interpolateAnim;
			}
			set
			{
				if (_interpolateAnim == value)
				{
					return;
				}
				_interpolateAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("startMargin")] 
		public inkMargin StartMargin
		{
			get
			{
				if (_startMargin == null)
				{
					_startMargin = (inkMargin) CR2WTypeManager.Create("inkMargin", "startMargin", cr2w, this);
				}
				return _startMargin;
			}
			set
			{
				if (_startMargin == value)
				{
					return;
				}
				_startMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animLength")] 
		public CFloat AnimLength
		{
			get
			{
				if (_animLength == null)
				{
					_animLength = (CFloat) CR2WTypeManager.Create("Float", "animLength", cr2w, this);
				}
				return _animLength;
			}
			set
			{
				if (_animLength == value)
				{
					return;
				}
				_animLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animConstructor")] 
		public CHandle<AnimationsConstructor> AnimConstructor
		{
			get
			{
				if (_animConstructor == null)
				{
					_animConstructor = (CHandle<AnimationsConstructor>) CR2WTypeManager.Create("handle:AnimationsConstructor", "animConstructor", cr2w, this);
				}
				return _animConstructor;
			}
			set
			{
				if (_animConstructor == value)
				{
					return;
				}
				_animConstructor = value;
				PropertySet(this);
			}
		}

		public InterpolatorsShowcaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
