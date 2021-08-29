using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimSetEntry : ISerializable
	{
		private CHandle<animAnimation> _animation;
		private CHandle<animEventsContainer> _events;

		[Ordinal(0)] 
		[RED("animation")] 
		public CHandle<animAnimation> Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CHandle<animEventsContainer> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}
	}
}
