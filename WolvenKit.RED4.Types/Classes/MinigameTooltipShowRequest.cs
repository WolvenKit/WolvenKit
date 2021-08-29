using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameTooltipShowRequest : redEvent
	{
		private CHandle<MessageTooltipData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<MessageTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
