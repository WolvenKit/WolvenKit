using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class drillMachineEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newTargetDevice")] 
		public CWeakHandle<gameObject> NewTargetDevice
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("newIsActive")] 
		public CBool NewIsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public drillMachineEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
