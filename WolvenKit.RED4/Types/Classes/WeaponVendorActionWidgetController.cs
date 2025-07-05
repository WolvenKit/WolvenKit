using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponVendorActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(32)] 
		[RED("buttonText")] 
		public inkTextWidgetReference ButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("standardButtonContainer")] 
		public inkWidgetReference StandardButtonContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("hoveredButtonContainer")] 
		public inkWidgetReference HoveredButtonContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("buttonState")] 
		public CEnum<ButtonStatus> ButtonState
		{
			get => GetPropertyValue<CEnum<ButtonStatus>>();
			set => SetPropertyValue<CEnum<ButtonStatus>>(value);
		}

		[Ordinal(36)] 
		[RED("hoverState")] 
		public CEnum<HoverStatus> HoverState
		{
			get => GetPropertyValue<CEnum<HoverStatus>>();
			set => SetPropertyValue<CEnum<HoverStatus>>(value);
		}

		[Ordinal(37)] 
		[RED("isBusy")] 
		public CBool IsBusy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WeaponVendorActionWidgetController()
		{
			ButtonText = new inkTextWidgetReference();
			StandardButtonContainer = new inkWidgetReference();
			HoveredButtonContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
