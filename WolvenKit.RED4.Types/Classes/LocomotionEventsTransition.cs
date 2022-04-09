using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LocomotionEventsTransition : LocomotionTransition
	{
		[Ordinal(3)] 
		[RED("causeContactDestruction")] 
		public CBool CauseContactDestruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("activatedDestructionComponent")] 
		public CBool ActivatedDestructionComponent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ignoreBarbedWire")] 
		public CBool IgnoreBarbedWire
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LocomotionEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
