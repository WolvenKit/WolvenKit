using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameTooltipShowRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<MessageTooltipData> Data
		{
			get => GetPropertyValue<CHandle<MessageTooltipData>>();
			set => SetPropertyValue<CHandle<MessageTooltipData>>(value);
		}
	}
}
