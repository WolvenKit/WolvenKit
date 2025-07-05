using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ncartDoorScreenLineDataDef : RedBaseClass
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
		[RED("lineSymbolWidget")] 
		public inkWidgetReference LineSymbolWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public ncartDoorScreenLineDataDef()
		{
			LineColor = new CColor();
			LineSymbolWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
