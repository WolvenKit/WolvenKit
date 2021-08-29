using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TarotCardPreviewPopupEvent : redEvent
	{
		private CHandle<TarotCardPreviewData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<TarotCardPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
