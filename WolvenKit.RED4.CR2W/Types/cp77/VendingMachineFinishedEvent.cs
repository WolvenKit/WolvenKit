using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineFinishedEvent : redEvent
	{
		private gameItemID _itemID;
		private CBool _isFree;
		private CBool _isReady;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetProperty(ref _isFree);
			set => SetProperty(ref _isFree, value);
		}

		[Ordinal(2)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetProperty(ref _isReady);
			set => SetProperty(ref _isReady, value);
		}

		public VendingMachineFinishedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
