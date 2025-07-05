using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HandleRagdollOnDeathEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("handleUncontrolledMovement")] 
		public CBool HandleUncontrolledMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HandleRagdollOnDeathEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
