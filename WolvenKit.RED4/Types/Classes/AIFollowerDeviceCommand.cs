using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFollowerDeviceCommand : AIFollowerCommand
	{
		[Ordinal(5)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("overrideMovementTarget")] 
		public CWeakHandle<gameObject> OverrideMovementTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public AIFollowerDeviceCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
