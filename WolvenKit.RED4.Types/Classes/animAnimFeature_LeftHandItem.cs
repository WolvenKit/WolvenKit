using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_LeftHandItem : animAnimFeature
	{
		private CBool _itemInLeftHand;

		[Ordinal(0)] 
		[RED("itemInLeftHand")] 
		public CBool ItemInLeftHand
		{
			get => GetProperty(ref _itemInLeftHand);
			set => SetProperty(ref _itemInLeftHand, value);
		}
	}
}
