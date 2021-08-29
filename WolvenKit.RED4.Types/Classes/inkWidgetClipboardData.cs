using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetClipboardData : ISerializable
	{
		private CHandle<inkWidget> _widget;
		private inkWidgetPath _widgetPath;

		[Ordinal(0)] 
		[RED("widget")] 
		public CHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("widgetPath")] 
		public inkWidgetPath WidgetPath
		{
			get => GetProperty(ref _widgetPath);
			set => SetProperty(ref _widgetPath, value);
		}
	}
}
