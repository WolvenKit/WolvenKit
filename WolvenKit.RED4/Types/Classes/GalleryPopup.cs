using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryPopup : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public GalleryPopup()
		{
			TitleText = new inkTextWidgetReference();
			MessageText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
