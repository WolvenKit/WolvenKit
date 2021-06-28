using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CleanEnvironmentalHazardEvent : redEvent
	{
		private CHandle<senseStimuliEvent> _stimEvent;

		[Ordinal(0)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetProperty(ref _stimEvent);
			set => SetProperty(ref _stimEvent, value);
		}

		public CleanEnvironmentalHazardEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
