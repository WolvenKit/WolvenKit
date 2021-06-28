using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardPreviewData : inkGameNotificationData
	{
		private TarotCardData _cardData;

		[Ordinal(6)] 
		[RED("cardData")] 
		public TarotCardData CardData
		{
			get => GetProperty(ref _cardData);
			set => SetProperty(ref _cardData, value);
		}

		public TarotCardPreviewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
