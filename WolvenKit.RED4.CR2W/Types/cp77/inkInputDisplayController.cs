using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInputDisplayController : inkWidgetLogicController
	{
		private inkWidgetReference _iconRef;
		private inkWidgetReference _nameRef;
		private inkWidgetReference _canvasRef;
		private inkCompoundWidgetReference _holdIndicatorContainerRef;
		private inkWidgetLibraryReference _gamepadHoldIndicatorLibraryRef;
		private inkWidgetLibraryReference _keyboardHoldIndicatorLibraryRef;
		private CBool _supportAnimatedHoldIndicator;
		private CEnum<inkInputHintHoldIndicationType> _holdIndicationType;
		private CName _inputActionName;
		private CFloat _fixedIconHeight;

		[Ordinal(1)] 
		[RED("iconRef")] 
		public inkWidgetReference IconRef
		{
			get
			{
				if (_iconRef == null)
				{
					_iconRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconRef", cr2w, this);
				}
				return _iconRef;
			}
			set
			{
				if (_iconRef == value)
				{
					return;
				}
				_iconRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nameRef")] 
		public inkWidgetReference NameRef
		{
			get
			{
				if (_nameRef == null)
				{
					_nameRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nameRef", cr2w, this);
				}
				return _nameRef;
			}
			set
			{
				if (_nameRef == value)
				{
					return;
				}
				_nameRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("canvasRef")] 
		public inkWidgetReference CanvasRef
		{
			get
			{
				if (_canvasRef == null)
				{
					_canvasRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "canvasRef", cr2w, this);
				}
				return _canvasRef;
			}
			set
			{
				if (_canvasRef == value)
				{
					return;
				}
				_canvasRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("holdIndicatorContainerRef")] 
		public inkCompoundWidgetReference HoldIndicatorContainerRef
		{
			get
			{
				if (_holdIndicatorContainerRef == null)
				{
					_holdIndicatorContainerRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "holdIndicatorContainerRef", cr2w, this);
				}
				return _holdIndicatorContainerRef;
			}
			set
			{
				if (_holdIndicatorContainerRef == value)
				{
					return;
				}
				_holdIndicatorContainerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("gamepadHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference GamepadHoldIndicatorLibraryRef
		{
			get
			{
				if (_gamepadHoldIndicatorLibraryRef == null)
				{
					_gamepadHoldIndicatorLibraryRef = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "gamepadHoldIndicatorLibraryRef", cr2w, this);
				}
				return _gamepadHoldIndicatorLibraryRef;
			}
			set
			{
				if (_gamepadHoldIndicatorLibraryRef == value)
				{
					return;
				}
				_gamepadHoldIndicatorLibraryRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("keyboardHoldIndicatorLibraryRef")] 
		public inkWidgetLibraryReference KeyboardHoldIndicatorLibraryRef
		{
			get
			{
				if (_keyboardHoldIndicatorLibraryRef == null)
				{
					_keyboardHoldIndicatorLibraryRef = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "keyboardHoldIndicatorLibraryRef", cr2w, this);
				}
				return _keyboardHoldIndicatorLibraryRef;
			}
			set
			{
				if (_keyboardHoldIndicatorLibraryRef == value)
				{
					return;
				}
				_keyboardHoldIndicatorLibraryRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("supportAnimatedHoldIndicator")] 
		public CBool SupportAnimatedHoldIndicator
		{
			get
			{
				if (_supportAnimatedHoldIndicator == null)
				{
					_supportAnimatedHoldIndicator = (CBool) CR2WTypeManager.Create("Bool", "supportAnimatedHoldIndicator", cr2w, this);
				}
				return _supportAnimatedHoldIndicator;
			}
			set
			{
				if (_supportAnimatedHoldIndicator == value)
				{
					return;
				}
				_supportAnimatedHoldIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get
			{
				if (_holdIndicationType == null)
				{
					_holdIndicationType = (CEnum<inkInputHintHoldIndicationType>) CR2WTypeManager.Create("inkInputHintHoldIndicationType", "holdIndicationType", cr2w, this);
				}
				return _holdIndicationType;
			}
			set
			{
				if (_holdIndicationType == value)
				{
					return;
				}
				_holdIndicationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("inputActionName")] 
		public CName InputActionName
		{
			get
			{
				if (_inputActionName == null)
				{
					_inputActionName = (CName) CR2WTypeManager.Create("CName", "inputActionName", cr2w, this);
				}
				return _inputActionName;
			}
			set
			{
				if (_inputActionName == value)
				{
					return;
				}
				_inputActionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("fixedIconHeight")] 
		public CFloat FixedIconHeight
		{
			get
			{
				if (_fixedIconHeight == null)
				{
					_fixedIconHeight = (CFloat) CR2WTypeManager.Create("Float", "fixedIconHeight", cr2w, this);
				}
				return _fixedIconHeight;
			}
			set
			{
				if (_fixedIconHeight == value)
				{
					return;
				}
				_fixedIconHeight = value;
				PropertySet(this);
			}
		}

		public inkInputDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
