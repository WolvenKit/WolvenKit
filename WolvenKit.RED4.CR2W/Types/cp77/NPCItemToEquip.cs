using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCItemToEquip : CVariable
	{
		private gameItemID _itemID;
		private TweakDBID _slotID;
		private TweakDBID _bodySlotID;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(2)] 
		[RED("bodySlotID")] 
		public TweakDBID BodySlotID
		{
			get => GetProperty(ref _bodySlotID);
			set => SetProperty(ref _bodySlotID, value);
		}

		public NPCItemToEquip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
