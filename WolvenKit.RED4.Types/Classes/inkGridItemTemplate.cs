using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGridItemTemplate : RedBaseClass
	{
		private CUInt32 _sizeX;
		private CUInt32 _sizeY;
		private inkWidgetLibraryReference _widget;

		[Ordinal(0)] 
		[RED("sizeX")] 
		public CUInt32 SizeX
		{
			get => GetProperty(ref _sizeX);
			set => SetProperty(ref _sizeX, value);
		}

		[Ordinal(1)] 
		[RED("sizeY")] 
		public CUInt32 SizeY
		{
			get => GetProperty(ref _sizeY);
			set => SetProperty(ref _sizeY, value);
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public inkWidgetLibraryReference Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}
	}
}
