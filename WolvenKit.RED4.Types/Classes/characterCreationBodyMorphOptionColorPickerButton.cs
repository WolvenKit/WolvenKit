using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationBodyMorphOptionColorPickerButton : inkWidgetLogicController
	{
		private inkWidgetReference _background;
		private inkImageWidgetReference _icon;
		private CBool _isTriggered;

		[Ordinal(1)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("isTriggered")] 
		public CBool IsTriggered
		{
			get => GetProperty(ref _isTriggered);
			set => SetProperty(ref _isTriggered, value);
		}
	}
}
