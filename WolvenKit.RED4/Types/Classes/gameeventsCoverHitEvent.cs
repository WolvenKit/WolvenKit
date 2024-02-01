using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsCoverHitEvent : gameeventsHitEvent
	{
		[Ordinal(11)] 
		[RED("cover")] 
		public CWeakHandle<gameObject> Cover
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public gameeventsCoverHitEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
