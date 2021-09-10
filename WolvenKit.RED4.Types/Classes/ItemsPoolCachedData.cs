using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemsPoolCachedData : IScriptable
	{
		[Ordinal(0)] 
		[RED("tooltipData")] 
		public CHandle<ATooltipData> TooltipData
		{
			get => GetPropertyValue<CHandle<ATooltipData>>();
			set => SetPropertyValue<CHandle<ATooltipData>>(value);
		}
	}
}
