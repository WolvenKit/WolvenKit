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

		[Ordinal(29)] 
		[RED("buttonText")] 
		public inkTextWidgetReference ButtonText
		{
			get => GetProperty(ref _buttonText);
			set => SetProperty(ref _buttonText, value);
		}

		[Ordinal(30)] 
		[RED("standardButtonContainer")] 
		public inkWidgetReference StandardButtonContainer
		{
			get => GetProperty(ref _standardButtonContainer);
			set => SetProperty(ref _standardButtonContainer, value);
		}

		[Ordinal(31)] 
		[RED("hoveredButtonContainer")] 
		public inkWidgetReference HoveredButtonContainer
		{
			get => GetProperty(ref _hoveredButtonContainer);
			set => SetProperty(ref _hoveredButtonContainer, value);
		}

		[Ordinal(32)] 
		[RED("buttonState")] 
		public CEnum<ButtonStatus> ButtonState
		{
			get => GetProperty(ref _buttonState);
			set => SetProperty(ref _buttonState, value);
		}

		[Ordinal(33)] 
		[RED("hoverState")] 
		public CEnum<HoverStatus> HoverState
		{
			get => GetProperty(ref _hoverState);
			set => SetProperty(ref _hoverState, value);
		}

		[Ordinal(34)] 
		[RED("isBusy")] 
		public CBool IsBusy
		{
			get => GetProperty(ref _isBusy);
			set => SetProperty(ref _isBusy, value);
		}

		public WeaponVendorActionWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
