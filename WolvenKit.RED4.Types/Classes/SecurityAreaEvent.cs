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
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			SecurityAreaData = new() { Id = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
