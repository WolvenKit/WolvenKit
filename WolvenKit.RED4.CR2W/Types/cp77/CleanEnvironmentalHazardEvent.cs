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
			get
			{
				if (_stimEvent == null)
				{
					_stimEvent = (CHandle<senseStimuliEvent>) CR2WTypeManager.Create("handle:senseStimuliEvent", "stimEvent", cr2w, this);
				}
				return _stimEvent;
			}
			set
			{
				if (_stimEvent == value)
				{
					return;
				}
				_stimEvent = value;
				PropertySet(this);
			}
		}

		public CleanEnvironmentalHazardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
