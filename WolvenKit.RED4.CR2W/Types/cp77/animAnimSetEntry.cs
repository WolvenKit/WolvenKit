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
			get
			{
				if (_animation == null)
				{
					_animation = (CHandle<animAnimation>) CR2WTypeManager.Create("handle:animAnimation", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CHandle<animEventsContainer> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CHandle<animEventsContainer>) CR2WTypeManager.Create("handle:animEventsContainer", "events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		public animAnimSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
