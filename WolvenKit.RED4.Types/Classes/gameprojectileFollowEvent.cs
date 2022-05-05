using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileFollowEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("followObject")] 
		public CWeakHandle<gameObject> FollowObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public gameprojectileFollowEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
