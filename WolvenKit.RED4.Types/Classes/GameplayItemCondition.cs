using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayItemCondition : GameplayConditionBase
	{
		private TweakDBID _itemToCheck;

		[Ordinal(1)] 
		[RED("itemToCheck")] 
		public TweakDBID ItemToCheck
		{
			get => GetProperty(ref _itemToCheck);
			set => SetProperty(ref _itemToCheck, value);
		}
	}
}
