using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class metroMapPlayerPositionReferences : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lineNumber")] 
		public CUInt32 LineNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("positionRefWidget")] 
		public inkWidgetReference PositionRefWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public metroMapPlayerPositionReferences()
		{
			PositionRefWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
