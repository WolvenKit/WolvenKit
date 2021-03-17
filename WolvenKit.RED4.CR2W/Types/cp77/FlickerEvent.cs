using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FlickerEvent : redEvent
	{
		private CFloat _strength;
		private CFloat _duration;
		private CFloat _offset;

		[Ordinal(0)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		public FlickerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
