using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkButtonTintController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("NormalColor")] 
		public CColor NormalColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(11)] 
		[RED("HoverColor")] 
		public CColor HoverColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(12)] 
		[RED("PressColor")] 
		public CColor PressColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(13)] 
		[RED("DisableColor")] 
		public CColor DisableColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(14)] 
		[RED("TintControlRef")] 
		public inkWidgetReference TintControlRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public inkButtonTintController()
		{
			NormalColor = new();
			HoverColor = new();
			PressColor = new();
			DisableColor = new();
			TintControlRef = new();
		}
	}
}
