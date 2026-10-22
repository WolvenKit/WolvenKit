using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestStopFollowingTarget : ActionBool
	{
		[Ordinal(39)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public QuestStopFollowingTarget()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			TargetEntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
