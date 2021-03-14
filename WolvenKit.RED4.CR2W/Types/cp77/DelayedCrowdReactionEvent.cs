using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedCrowdReactionEvent : redEvent
	{
		private CHandle<senseStimuliEvent> _stimEvent;
		private CInt32 _vehicleFearPhase;

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

		[Ordinal(1)] 
		[RED("vehicleFearPhase")] 
		public CInt32 VehicleFearPhase
		{
			get
			{
				if (_vehicleFearPhase == null)
				{
					_vehicleFearPhase = (CInt32) CR2WTypeManager.Create("Int32", "vehicleFearPhase", cr2w, this);
				}
				return _vehicleFearPhase;
			}
			set
			{
				if (_vehicleFearPhase == value)
				{
					return;
				}
				_vehicleFearPhase = value;
				PropertySet(this);
			}
		}

		public DelayedCrowdReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
