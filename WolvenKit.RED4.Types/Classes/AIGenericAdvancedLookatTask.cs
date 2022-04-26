using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIGenericAdvancedLookatTask : AIGenericLookatTask
	{
		[Ordinal(0)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("lookatTarget")] 
		public CWeakHandle<entEntity> LookatTarget
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public AIGenericAdvancedLookatTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
