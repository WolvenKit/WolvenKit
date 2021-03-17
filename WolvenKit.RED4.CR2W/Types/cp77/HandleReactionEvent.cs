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
			get => GetProperty(ref _fearPhase);
			set => SetProperty(ref _fearPhase, value);
		}

		[Ordinal(1)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetProperty(ref _stimEvent);
			set => SetProperty(ref _stimEvent, value);
		}

		[Ordinal(2)] 
		[RED("eventResent")] 
		public CBool EventResent
		{
			get => GetProperty(ref _eventResent);
			set => SetProperty(ref _eventResent, value);
		}

		public HandleReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
