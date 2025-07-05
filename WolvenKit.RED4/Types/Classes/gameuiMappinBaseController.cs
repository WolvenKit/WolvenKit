using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiMappinBaseController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("playerTrackedWidget")] 
		public inkWidgetReference PlayerTrackedWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("scaleWidget")] 
		public inkWidgetReference ScaleWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("animPlayerTrackedWidget")] 
		public inkWidgetReference AnimPlayerTrackedWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("animPlayerAboveBelowWidget")] 
		public inkWidgetReference AnimPlayerAboveBelowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("taggedWidgets")] 
		public CArray<inkWidgetReference> TaggedWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public gameuiMappinBaseController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
