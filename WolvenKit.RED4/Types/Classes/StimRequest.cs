using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("stimuli")] 
		public CHandle<senseStimuliEvent> Stimuli
		{
			get => GetPropertyValue<CHandle<senseStimuliEvent>>();
			set => SetPropertyValue<CHandle<senseStimuliEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("hasExpirationDate")] 
		public CBool HasExpirationDate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("requestID")] 
		public StimRequestID RequestID
		{
			get => GetPropertyValue<StimRequestID>();
			set => SetPropertyValue<StimRequestID>(value);
		}

		public StimRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
