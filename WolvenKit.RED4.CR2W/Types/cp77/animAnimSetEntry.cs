using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetEntry : ISerializable
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

		public animAnimSetEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
