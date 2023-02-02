using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VoiceOverQuickHackFeedbackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("voName")] 
		public CName VoName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public VoiceOverQuickHackFeedbackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
