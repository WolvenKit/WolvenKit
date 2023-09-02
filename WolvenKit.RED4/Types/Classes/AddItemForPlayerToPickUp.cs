using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddItemForPlayerToPickUp : ScriptableDeviceAction
	{
		[Ordinal(25)] 
		[RED("lootTable")] 
		public TweakDBID LootTable
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(26)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AddItemForPlayerToPickUp()
		{
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;
			ShouldAdd = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
