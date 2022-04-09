using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRagdollActivationRequestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public entragdollActivationRequestData Data
		{
			get => GetPropertyValue<entragdollActivationRequestData>();
			set => SetPropertyValue<entragdollActivationRequestData>(value);
		}

		public entRagdollActivationRequestEvent()
		{
			Data = new() { ActivateOnCollision = true, ApplyPowerPose = true, ApplyMomentum = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
