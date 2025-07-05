using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entLookAtRemoveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("lookAtRef")] 
		public animLookAtRef LookAtRef
		{
			get => GetPropertyValue<animLookAtRef>();
			set => SetPropertyValue<animLookAtRef>(value);
		}

		[Ordinal(1)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entLookAtRemoveEvent()
		{
			LookAtRef = new animLookAtRef { Id = -1 };
			OutTransitionSpeed = 60.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
