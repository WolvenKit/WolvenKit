using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnscreenDisplayManager : inkWidgetLogicController
	{
		private inkTextWidgetReference _contentText;

		[Ordinal(1)] 
		[RED("contentText")] 
		public inkTextWidgetReference ContentText
		{
			get => GetProperty(ref _contentText);
			set => SetProperty(ref _contentText, value);
		}
	}
}
