using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoiceCaptionIconPart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)] 
		[RED("iconRecord")] 
		public CWeakHandle<gamedataChoiceCaptionIconPart_Record> IconRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataChoiceCaptionIconPart_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataChoiceCaptionIconPart_Record>>(value);
		}

		public gameinteractionsChoiceCaptionIconPart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
