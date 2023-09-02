using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAreaEvent : ActionBool
	{
		[Ordinal(25)] 
		[RED("securityAreaData")] 
		public SecurityAreaData SecurityAreaData
		{
			get => GetPropertyValue<SecurityAreaData>();
			set => SetPropertyValue<SecurityAreaData>(value);
		}

		[Ordinal(26)] 
		[RED("whoBreached")] 
		public CWeakHandle<gameObject> WhoBreached
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public SecurityAreaEvent()
		{
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;
			SecurityAreaData = new SecurityAreaData { Id = new gamePersistentID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
