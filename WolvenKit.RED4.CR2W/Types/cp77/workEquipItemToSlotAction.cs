using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workEquipItemToSlotAction : workIWorkspotItemAction
	{
		private TweakDBID _item;
		private TweakDBID _itemSlot;

		[Ordinal(0)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(1)] 
		[RED("itemSlot")] 
		public TweakDBID ItemSlot
		{
			get => GetProperty(ref _itemSlot);
			set => SetProperty(ref _itemSlot, value);
		}

		public workEquipItemToSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
