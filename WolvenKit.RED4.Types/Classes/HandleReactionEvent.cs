using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HandleReactionEvent : redEvent
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
	}
}
