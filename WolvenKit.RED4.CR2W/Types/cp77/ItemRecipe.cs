using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemRecipe : CVariable
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

		public ItemRecipe(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
