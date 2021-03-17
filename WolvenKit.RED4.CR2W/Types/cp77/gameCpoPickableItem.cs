using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCpoPickableItem : gameObject
	{
		private TweakDBID _itemIDToEquip;
		private CInt32 _quickSlotID;

		[Ordinal(40)] 
		[RED("itemIDToEquip")] 
		public TweakDBID ItemIDToEquip
		{
			get => GetProperty(ref _itemIDToEquip);
			set => SetProperty(ref _itemIDToEquip, value);
		}

		[Ordinal(41)] 
		[RED("quickSlotID")] 
		public CInt32 QuickSlotID
		{
			get => GetProperty(ref _quickSlotID);
			set => SetProperty(ref _quickSlotID, value);
		}

		public gameCpoPickableItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
