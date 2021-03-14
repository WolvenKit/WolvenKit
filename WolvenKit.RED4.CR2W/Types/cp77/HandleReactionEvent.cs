using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HandleReactionEvent : redEvent
	{
		private CInt32 _fearPhase;
		private CHandle<senseStimuliEvent> _stimEvent;
		private CBool _eventResent;

		[Ordinal(0)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get
			{
				if (_fearPhase == null)
				{
					_fearPhase = (CInt32) CR2WTypeManager.Create("Int32", "fearPhase", cr2w, this);
				}
				return _fearPhase;
			}
			set
			{
				if (_fearPhase == value)
				{
					return;
				}
				_fearPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("eventResent")] 
		public CBool EventResent
		{
			get
			{
				if (_eventResent == null)
				{
					_eventResent = (CBool) CR2WTypeManager.Create("Bool", "eventResent", cr2w, this);
				}
				return _eventResent;
			}
			set
			{
				if (_eventResent == value)
				{
					return;
				}
				_eventResent = value;
				PropertySet(this);
			}
		}

		public HandleReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
