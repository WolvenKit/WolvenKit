using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleDriveToGameObjectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetObjToReach")] 
		public CWeakHandle<gameObject> TargetObjToReach
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public vehicleDriveToGameObjectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
