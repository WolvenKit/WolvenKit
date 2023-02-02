using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeCameraLocation : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkWidgetReference TextWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public PhotoModeCameraLocation()
		{
			TextWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
