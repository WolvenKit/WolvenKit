using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGenericSystemNotificationLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleTextWidget;
		private inkTextWidgetReference _descriptionTextWidget;
		private inkTextWidgetReference _additionalDataTextWidget;
		private CName _introAnimationName;
		private CName _outroAnimationName;
		private inkWidgetReference _confirmButton;
		private inkWidgetReference _cancelButton;

		[Ordinal(1)] 
		[RED("titleTextWidget")] 
		public inkTextWidgetReference TitleTextWidget
		{
			get => GetProperty(ref _titleTextWidget);
			set => SetProperty(ref _titleTextWidget, value);
		}

		[Ordinal(2)] 
		[RED("descriptionTextWidget")] 
		public inkTextWidgetReference DescriptionTextWidget
		{
			get => GetProperty(ref _descriptionTextWidget);
			set => SetProperty(ref _descriptionTextWidget, value);
		}

		[Ordinal(3)] 
		[RED("additionalDataTextWidget")] 
		public inkTextWidgetReference AdditionalDataTextWidget
		{
			get => GetProperty(ref _additionalDataTextWidget);
			set => SetProperty(ref _additionalDataTextWidget, value);
		}

		[Ordinal(4)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetProperty(ref _outroAnimationName);
			set => SetProperty(ref _outroAnimationName, value);
		}

		[Ordinal(6)] 
		[RED("confirmButton")] 
		public inkWidgetReference ConfirmButton
		{
			get => GetProperty(ref _confirmButton);
			set => SetProperty(ref _confirmButton, value);
		}

		[Ordinal(7)] 
		[RED("cancelButton")] 
		public inkWidgetReference CancelButton
		{
			get => GetProperty(ref _cancelButton);
			set => SetProperty(ref _cancelButton, value);
		}
	}
}
