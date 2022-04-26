using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRegisterController : gameuiBaseGOGRegisterController
	{
		[Ordinal(1)] 
		[RED("linkWidget")] 
		public inkWidgetReference LinkWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("qrImageWidget")] 
		public inkWidgetReference QrImageWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public GogRegisterController()
		{
			LinkWidget = new();
			QrImageWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
