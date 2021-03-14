using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponVendorActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkTextWidgetReference _buttonText;
		private inkWidgetReference _standardButtonContainer;
		private inkWidgetReference _hoveredButtonContainer;
		private CEnum<ButtonStatus> _buttonState;
		private CEnum<HoverStatus> _hoverState;
		private CBool _isBusy;

		[Ordinal(28)] 
		[RED("buttonText")] 
		public inkTextWidgetReference ButtonText
		{
			get
			{
				if (_buttonText == null)
				{
					_buttonText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "buttonText", cr2w, this);
				}
				return _buttonText;
			}
			set
			{
				if (_buttonText == value)
				{
					return;
				}
				_buttonText = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("standardButtonContainer")] 
		public inkWidgetReference StandardButtonContainer
		{
			get
			{
				if (_standardButtonContainer == null)
				{
					_standardButtonContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "standardButtonContainer", cr2w, this);
				}
				return _standardButtonContainer;
			}
			set
			{
				if (_standardButtonContainer == value)
				{
					return;
				}
				_standardButtonContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("hoveredButtonContainer")] 
		public inkWidgetReference HoveredButtonContainer
		{
			get
			{
				if (_hoveredButtonContainer == null)
				{
					_hoveredButtonContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hoveredButtonContainer", cr2w, this);
				}
				return _hoveredButtonContainer;
			}
			set
			{
				if (_hoveredButtonContainer == value)
				{
					return;
				}
				_hoveredButtonContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("buttonState")] 
		public CEnum<ButtonStatus> ButtonState
		{
			get
			{
				if (_buttonState == null)
				{
					_buttonState = (CEnum<ButtonStatus>) CR2WTypeManager.Create("ButtonStatus", "buttonState", cr2w, this);
				}
				return _buttonState;
			}
			set
			{
				if (_buttonState == value)
				{
					return;
				}
				_buttonState = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("hoverState")] 
		public CEnum<HoverStatus> HoverState
		{
			get
			{
				if (_hoverState == null)
				{
					_hoverState = (CEnum<HoverStatus>) CR2WTypeManager.Create("HoverStatus", "hoverState", cr2w, this);
				}
				return _hoverState;
			}
			set
			{
				if (_hoverState == value)
				{
					return;
				}
				_hoverState = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("isBusy")] 
		public CBool IsBusy
		{
			get
			{
				if (_isBusy == null)
				{
					_isBusy = (CBool) CR2WTypeManager.Create("Bool", "isBusy", cr2w, this);
				}
				return _isBusy;
			}
			set
			{
				if (_isBusy == value)
				{
					return;
				}
				_isBusy = value;
				PropertySet(this);
			}
		}

		public WeaponVendorActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
