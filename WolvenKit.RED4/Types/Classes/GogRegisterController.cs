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

		[Ordinal(3)] 
		[RED("textDescription")] 
		public inkTextWidgetReference TextDescription
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public GogRegisterController()
		{
			LinkWidget = new inkWidgetReference();
			QrImageWidget = new inkWidgetReference();
			TextDescription = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
