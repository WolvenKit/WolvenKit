using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReserveItemToThisDropPoint : ScriptableDeviceAction
	{
		[Ordinal(25)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ReserveItemToThisDropPoint()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
