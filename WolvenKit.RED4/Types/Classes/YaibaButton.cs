using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class YaibaButton : inkButtonController
	{
		[Ordinal(13)] 
		[RED("normalBackground")] 
		public inkImageWidgetReference NormalBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("pressBackground")] 
		public inkImageWidgetReference PressBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("hoverBackground")] 
		public inkImageWidgetReference HoverBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("disabledBackground")] 
		public inkImageWidgetReference DisabledBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("enabledText")] 
		public inkTextWidgetReference EnabledText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("disabledText")] 
		public inkTextWidgetReference DisabledText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public YaibaButton()
		{
			NormalBackground = new inkImageWidgetReference();
			PressBackground = new inkImageWidgetReference();
			HoverBackground = new inkImageWidgetReference();
			DisabledBackground = new inkImageWidgetReference();
			EnabledText = new inkTextWidgetReference();
			DisabledText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
