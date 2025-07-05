using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetClipboardData : ISerializable
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CHandle<inkWidget>>();
			set => SetPropertyValue<CHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("widgetPath")] 
		public inkWidgetPath WidgetPath
		{
			get => GetPropertyValue<inkWidgetPath>();
			set => SetPropertyValue<inkWidgetPath>(value);
		}

		public inkWidgetClipboardData()
		{
			WidgetPath = new inkWidgetPath { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
