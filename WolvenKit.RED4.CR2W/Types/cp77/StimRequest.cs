using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimRequest : IScriptable
	{
		private CHandle<senseStimuliEvent> _stimuli;
		private CBool _hasExpirationDate;
		private CFloat _duration;
		private StimRequestID _requestID;

		[Ordinal(0)] 
		[RED("stimuli")] 
		public CHandle<senseStimuliEvent> Stimuli
		{
			get => GetProperty(ref _stimuli);
			set => SetProperty(ref _stimuli, value);
		}

		[Ordinal(1)] 
		[RED("hasExpirationDate")] 
		public CBool HasExpirationDate
		{
			get => GetProperty(ref _hasExpirationDate);
			set => SetProperty(ref _hasExpirationDate, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("requestID")] 
		public StimRequestID RequestID
		{
			get => GetProperty(ref _requestID);
			set => SetProperty(ref _requestID, value);
		}

		public StimRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
