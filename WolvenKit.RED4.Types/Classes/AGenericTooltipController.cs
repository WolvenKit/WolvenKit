using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AGenericTooltipController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("Root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}
	}
}
