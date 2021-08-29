using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSSlotActiveItems : RedBaseClass
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
	}
}
