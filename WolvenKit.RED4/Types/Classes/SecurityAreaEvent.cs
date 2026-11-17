using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAreaEvent : ActionBool
	{
		[Ordinal(39)] 
		[RED("securityAreaData")] 
		public SecurityAreaData SecurityAreaData
		{
			get => GetPropertyValue<SecurityAreaData>();
			set => SetPropertyValue<SecurityAreaData>(value);
		}

		[Ordinal(40)] 
		[RED("whoBreached")] 
		public CWeakHandle<gameObject> WhoBreached
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public SecurityAreaEvent()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			SecurityAreaData = new SecurityAreaData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
