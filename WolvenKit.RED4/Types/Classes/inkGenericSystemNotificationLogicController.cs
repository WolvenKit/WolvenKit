using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGenericSystemNotificationLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleTextWidget")] 
		public inkTextWidgetReference TitleTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("descriptionTextWidget")] 
		public inkTextWidgetReference DescriptionTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("additionalDataTextWidget")] 
		public inkTextWidgetReference AdditionalDataTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("confirmButton")] 
		public inkWidgetReference ConfirmButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("cancelButton")] 
		public inkWidgetReference CancelButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("DataSetByToken")] 
		public inkEmptyCallback DataSetByToken
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		public inkGenericSystemNotificationLogicController()
		{
			TitleTextWidget = new inkTextWidgetReference();
			DescriptionTextWidget = new inkTextWidgetReference();
			AdditionalDataTextWidget = new inkTextWidgetReference();
			ConfirmButton = new inkWidgetReference();
			CancelButton = new inkWidgetReference();
			DataSetByToken = new inkEmptyCallback();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
