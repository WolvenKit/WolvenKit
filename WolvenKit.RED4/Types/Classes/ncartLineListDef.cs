using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ncartLineListDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lineNumber")] 
		public CUInt32 LineNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("lineColor")] 
		public CColor LineColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("stationsList")] 
		public CArray<ncartStationListDef> StationsList
		{
			get => GetPropertyValue<CArray<ncartStationListDef>>();
			set => SetPropertyValue<CArray<ncartStationListDef>>(value);
		}

		[Ordinal(3)] 
		[RED("lineSymbolWidget")] 
		public inkWidgetReference LineSymbolWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("lineIsLooped")] 
		public CBool LineIsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ncartLineListDef()
		{
			LineColor = new CColor();
			StationsList = new();
			LineSymbolWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
