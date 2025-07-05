using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimSetEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("animation")] 
		public CHandle<animAnimation> Animation
		{
			get => GetPropertyValue<CHandle<animAnimation>>();
			set => SetPropertyValue<CHandle<animAnimation>>(value);
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CHandle<animEventsContainer> Events
		{
			get => GetPropertyValue<CHandle<animEventsContainer>>();
			set => SetPropertyValue<CHandle<animEventsContainer>>(value);
		}

		public animAnimSetEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
