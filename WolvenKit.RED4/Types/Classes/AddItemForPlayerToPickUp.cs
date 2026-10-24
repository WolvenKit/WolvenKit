using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddItemForPlayerToPickUp : ScriptableDeviceAction
	{
		[Ordinal(39)] 
		[RED("lootTable")] 
		public TweakDBID LootTable
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(40)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AddItemForPlayerToPickUp()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			ShouldAdd = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
