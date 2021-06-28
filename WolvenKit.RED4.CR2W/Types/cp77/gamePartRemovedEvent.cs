using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePartRemovedEvent : redEvent
	{
		private gameItemID _itemID;
		private gameItemID _removedPartID;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("removedPartID")] 
		public gameItemID RemovedPartID
		{
			get => GetProperty(ref _removedPartID);
			set => SetProperty(ref _removedPartID, value);
		}

		public gamePartRemovedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
