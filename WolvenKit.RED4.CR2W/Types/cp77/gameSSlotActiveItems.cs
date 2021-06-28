using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSSlotActiveItems : CVariable
	{
		private gameItemID _rightHandItem;
		private gameItemID _leftHandItem;

		[Ordinal(0)] 
		[RED("rightHandItem")] 
		public gameItemID RightHandItem
		{
			get => GetProperty(ref _rightHandItem);
			set => SetProperty(ref _rightHandItem, value);
		}

		[Ordinal(1)] 
		[RED("leftHandItem")] 
		public gameItemID LeftHandItem
		{
			get => GetProperty(ref _leftHandItem);
			set => SetProperty(ref _leftHandItem, value);
		}

		public gameSSlotActiveItems(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
