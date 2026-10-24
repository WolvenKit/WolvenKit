using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetAssessmentRequest : ScriptableDeviceAction
	{
		[Ordinal(39)] 
		[RED("targetToAssess")] 
		public CWeakHandle<gameObject> TargetToAssess
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public TargetAssessmentRequest()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
