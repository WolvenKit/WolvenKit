using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUICustomizableAnimationsController : inkWidgetLogicController
	{
		private CName _imagePath;
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private CFloat _delayTime;
		private CHandle<inkanimDefinition> _rotation_anim;
		private CHandle<inkanimDefinition> _size_anim;
		private CHandle<inkanimDefinition> _color_anim;
		private CHandle<inkanimDefinition> _alpha_anim;
		private CHandle<inkanimDefinition> _position_anim;
		private wCHandle<inkWidget> _imageWidget;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _canRotate;
		private CBool _canResize;
		private CBool _canChangeColor;
		private CBool _canChangeAlpha;
		private CBool _canMove;
		private Vector2 _defaultSize;
		private inkMargin _defaultMargin;
		private CFloat _defaultRotation;
		private HDRColor _defaultColor;
		private CFloat _defaultAlpha;
		private CBool _isHighlighted;
		private wCHandle<inkWidget> _currentTarget;
		private CHandle<inkanimProxy> _currentAnimProxy;

		[Ordinal(1)] 
		[RED("imagePath")] 
		public CName ImagePath
		{
			get
			{
				if (_imagePath == null)
				{
					_imagePath = (CName) CR2WTypeManager.Create("CName", "imagePath", cr2w, this);
				}
				return _imagePath;
			}
			set
			{
				if (_imagePath == value)
				{
					return;
				}
				_imagePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get
			{
				if (_delayTime == null)
				{
					_delayTime = (CFloat) CR2WTypeManager.Create("Float", "delayTime", cr2w, this);
				}
				return _delayTime;
			}
			set
			{
				if (_delayTime == value)
				{
					return;
				}
				_delayTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rotation_anim")] 
		public CHandle<inkanimDefinition> Rotation_anim
		{
			get
			{
				if (_rotation_anim == null)
				{
					_rotation_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "rotation_anim", cr2w, this);
				}
				return _rotation_anim;
			}
			set
			{
				if (_rotation_anim == value)
				{
					return;
				}
				_rotation_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("size_anim")] 
		public CHandle<inkanimDefinition> Size_anim
		{
			get
			{
				if (_size_anim == null)
				{
					_size_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "size_anim", cr2w, this);
				}
				return _size_anim;
			}
			set
			{
				if (_size_anim == value)
				{
					return;
				}
				_size_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("color_anim")] 
		public CHandle<inkanimDefinition> Color_anim
		{
			get
			{
				if (_color_anim == null)
				{
					_color_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "color_anim", cr2w, this);
				}
				return _color_anim;
			}
			set
			{
				if (_color_anim == value)
				{
					return;
				}
				_color_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("alpha_anim")] 
		public CHandle<inkanimDefinition> Alpha_anim
		{
			get
			{
				if (_alpha_anim == null)
				{
					_alpha_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_anim", cr2w, this);
				}
				return _alpha_anim;
			}
			set
			{
				if (_alpha_anim == value)
				{
					return;
				}
				_alpha_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("position_anim")] 
		public CHandle<inkanimDefinition> Position_anim
		{
			get
			{
				if (_position_anim == null)
				{
					_position_anim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "position_anim", cr2w, this);
				}
				return _position_anim;
			}
			set
			{
				if (_position_anim == value)
				{
					return;
				}
				_position_anim = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("imageWidget")] 
		public wCHandle<inkWidget> ImageWidget
		{
			get
			{
				if (_imageWidget == null)
				{
					_imageWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "imageWidget", cr2w, this);
				}
				return _imageWidget;
			}
			set
			{
				if (_imageWidget == value)
				{
					return;
				}
				_imageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("CanRotate")] 
		public CBool CanRotate
		{
			get
			{
				if (_canRotate == null)
				{
					_canRotate = (CBool) CR2WTypeManager.Create("Bool", "CanRotate", cr2w, this);
				}
				return _canRotate;
			}
			set
			{
				if (_canRotate == value)
				{
					return;
				}
				_canRotate = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("CanResize")] 
		public CBool CanResize
		{
			get
			{
				if (_canResize == null)
				{
					_canResize = (CBool) CR2WTypeManager.Create("Bool", "CanResize", cr2w, this);
				}
				return _canResize;
			}
			set
			{
				if (_canResize == value)
				{
					return;
				}
				_canResize = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("CanChangeColor")] 
		public CBool CanChangeColor
		{
			get
			{
				if (_canChangeColor == null)
				{
					_canChangeColor = (CBool) CR2WTypeManager.Create("Bool", "CanChangeColor", cr2w, this);
				}
				return _canChangeColor;
			}
			set
			{
				if (_canChangeColor == value)
				{
					return;
				}
				_canChangeColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("CanChangeAlpha")] 
		public CBool CanChangeAlpha
		{
			get
			{
				if (_canChangeAlpha == null)
				{
					_canChangeAlpha = (CBool) CR2WTypeManager.Create("Bool", "CanChangeAlpha", cr2w, this);
				}
				return _canChangeAlpha;
			}
			set
			{
				if (_canChangeAlpha == value)
				{
					return;
				}
				_canChangeAlpha = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("CanMove")] 
		public CBool CanMove
		{
			get
			{
				if (_canMove == null)
				{
					_canMove = (CBool) CR2WTypeManager.Create("Bool", "CanMove", cr2w, this);
				}
				return _canMove;
			}
			set
			{
				if (_canMove == value)
				{
					return;
				}
				_canMove = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("defaultSize")] 
		public Vector2 DefaultSize
		{
			get
			{
				if (_defaultSize == null)
				{
					_defaultSize = (Vector2) CR2WTypeManager.Create("Vector2", "defaultSize", cr2w, this);
				}
				return _defaultSize;
			}
			set
			{
				if (_defaultSize == value)
				{
					return;
				}
				_defaultSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get
			{
				if (_defaultMargin == null)
				{
					_defaultMargin = (inkMargin) CR2WTypeManager.Create("inkMargin", "defaultMargin", cr2w, this);
				}
				return _defaultMargin;
			}
			set
			{
				if (_defaultMargin == value)
				{
					return;
				}
				_defaultMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("defaultRotation")] 
		public CFloat DefaultRotation
		{
			get
			{
				if (_defaultRotation == null)
				{
					_defaultRotation = (CFloat) CR2WTypeManager.Create("Float", "defaultRotation", cr2w, this);
				}
				return _defaultRotation;
			}
			set
			{
				if (_defaultRotation == value)
				{
					return;
				}
				_defaultRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get
			{
				if (_defaultColor == null)
				{
					_defaultColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "defaultColor", cr2w, this);
				}
				return _defaultColor;
			}
			set
			{
				if (_defaultColor == value)
				{
					return;
				}
				_defaultColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("defaultAlpha")] 
		public CFloat DefaultAlpha
		{
			get
			{
				if (_defaultAlpha == null)
				{
					_defaultAlpha = (CFloat) CR2WTypeManager.Create("Float", "defaultAlpha", cr2w, this);
				}
				return _defaultAlpha;
			}
			set
			{
				if (_defaultAlpha == value)
				{
					return;
				}
				_defaultAlpha = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isHighlighted")] 
		public CBool IsHighlighted
		{
			get
			{
				if (_isHighlighted == null)
				{
					_isHighlighted = (CBool) CR2WTypeManager.Create("Bool", "isHighlighted", cr2w, this);
				}
				return _isHighlighted;
			}
			set
			{
				if (_isHighlighted == value)
				{
					return;
				}
				_isHighlighted = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("currentTarget")] 
		public wCHandle<inkWidget> CurrentTarget
		{
			get
			{
				if (_currentTarget == null)
				{
					_currentTarget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "currentTarget", cr2w, this);
				}
				return _currentTarget;
			}
			set
			{
				if (_currentTarget == value)
				{
					return;
				}
				_currentTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("currentAnimProxy")] 
		public CHandle<inkanimProxy> CurrentAnimProxy
		{
			get
			{
				if (_currentAnimProxy == null)
				{
					_currentAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "currentAnimProxy", cr2w, this);
				}
				return _currentAnimProxy;
			}
			set
			{
				if (_currentAnimProxy == value)
				{
					return;
				}
				_currentAnimProxy = value;
				PropertySet(this);
			}
		}

		public sampleUICustomizableAnimationsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
