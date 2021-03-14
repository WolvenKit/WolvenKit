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
			get
			{
				if (_cardData == null)
				{
					_cardData = (TarotCardData) CR2WTypeManager.Create("TarotCardData", "cardData", cr2w, this);
				}
				return _cardData;
			}
			set
			{
				if (_cardData == value)
				{
					return;
				}
				_cardData = value;
				PropertySet(this);
			}
		}

		public TarotCardPreviewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
