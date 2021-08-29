using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentWidgets : RedBaseClass
	{
		private CArray<inkWidgetReference> _widgetArray;

		[Ordinal(0)] 
		[RED("widgetArray")] 
		public CArray<inkWidgetReference> WidgetArray
		{
			get => GetProperty(ref _widgetArray);
			set => SetProperty(ref _widgetArray, value);
		}
	}
}
