using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkButtonTintController : inkButtonController
	{
		[Ordinal(13)] 
		[RED("NormalColor")] 
		public CColor NormalColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(14)] 
		[RED("HoverColor")] 
		public CColor HoverColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(15)] 
		[RED("PressColor")] 
		public CColor PressColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(16)] 
		[RED("DisableColor")] 
		public CColor DisableColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(17)] 
		[RED("TintControlRef")] 
		public inkWidgetReference TintControlRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public inkButtonTintController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
