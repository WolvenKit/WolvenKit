using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestFollowTarget : ActionEntityReference
	{
		[Ordinal(39)] 
		[RED("ForcedTarget")] 
		public entEntityID ForcedTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public QuestFollowTarget()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			ForcedTarget = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
