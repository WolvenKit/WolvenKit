using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkDisplayContainerCreatedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public CWeakHandle<PerkDisplayContainerController> Container
		{
			get => GetPropertyValue<CWeakHandle<PerkDisplayContainerController>>();
			set => SetPropertyValue<CWeakHandle<PerkDisplayContainerController>>(value);
		}

		public PerkDisplayContainerCreatedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
