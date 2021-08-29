using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceCaptionIconPart : gameinteractionsChoiceCaptionPart
	{
		private CWeakHandle<gamedataChoiceCaptionIconPart_Record> _iconRecord;

		[Ordinal(0)] 
		[RED("iconRecord")] 
		public CWeakHandle<gamedataChoiceCaptionIconPart_Record> IconRecord
		{
			get => GetProperty(ref _iconRecord);
			set => SetProperty(ref _iconRecord, value);
		}
	}
}
