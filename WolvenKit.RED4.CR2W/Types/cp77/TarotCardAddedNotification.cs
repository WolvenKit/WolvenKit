using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardAddedNotification : GenericNotificationController
	{
		private inkImageWidgetReference _cardImage;
		private inkTextWidgetReference _cardNameLabel;

		[Ordinal(12)] 
		[RED("cardImage")] 
		public inkImageWidgetReference CardImage
		{
			get
			{
				if (_cardImage == null)
				{
					_cardImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "cardImage", cr2w, this);
				}
				return _cardImage;
			}
			set
			{
				if (_cardImage == value)
				{
					return;
				}
				_cardImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("cardNameLabel")] 
		public inkTextWidgetReference CardNameLabel
		{
			get
			{
				if (_cardNameLabel == null)
				{
					_cardNameLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "cardNameLabel", cr2w, this);
				}
				return _cardNameLabel;
			}
			set
			{
				if (_cardNameLabel == value)
				{
					return;
				}
				_cardNameLabel = value;
				PropertySet(this);
			}
		}

		public TarotCardAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
