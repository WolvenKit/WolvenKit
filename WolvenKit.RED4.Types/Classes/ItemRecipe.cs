using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemRecipe : RedBaseClass
	{
		private TweakDBID _targetItem;
		private CBool _isHidden;
		private CInt32 _amount;

		[Ordinal(0)] 
		[RED("targetItem")] 
		public TweakDBID TargetItem
		{
			get => GetProperty(ref _targetItem);
			set => SetProperty(ref _targetItem, value);
		}

		[Ordinal(1)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}
	}
}
