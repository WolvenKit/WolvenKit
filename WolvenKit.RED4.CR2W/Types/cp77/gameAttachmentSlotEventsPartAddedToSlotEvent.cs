using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotEventsPartAddedToSlotEvent : redEvent
	{
		private gameItemID _itemID;
		private gameItemID _partID;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("partID")] 
		public gameItemID PartID
		{
			get => GetProperty(ref _partID);
			set => SetProperty(ref _partID, value);
		}

		public gameAttachmentSlotEventsPartAddedToSlotEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
