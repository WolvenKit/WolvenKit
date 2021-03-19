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
			get => GetProperty(ref _cardImage);
			set => SetProperty(ref _cardImage, value);
		}

		[Ordinal(13)] 
		[RED("cardNameLabel")] 
		public inkTextWidgetReference CardNameLabel
		{
			get => GetProperty(ref _cardNameLabel);
			set => SetProperty(ref _cardNameLabel, value);
		}

		public TarotCardAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
