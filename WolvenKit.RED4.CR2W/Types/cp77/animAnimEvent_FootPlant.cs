using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootPlant : animAnimEvent
	{
		private CEnum<animEventSide> _side;
		private CName _customEvent;

		[Ordinal(3)] 
		[RED("side")] 
		public CEnum<animEventSide> Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}

		[Ordinal(4)] 
		[RED("customEvent")] 
		public CName CustomEvent
		{
			get => GetProperty(ref _customEvent);
			set => SetProperty(ref _customEvent, value);
		}

		public animAnimEvent_FootPlant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
