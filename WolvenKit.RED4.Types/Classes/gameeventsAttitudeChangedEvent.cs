using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsAttitudeChangedEvent : redEvent
	{
		private CWeakHandle<gameAttitudeAgent> _otherAgent;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(0)] 
		[RED("otherAgent")] 
		public CWeakHandle<gameAttitudeAgent> OtherAgent
		{
			get => GetProperty(ref _otherAgent);
			set => SetProperty(ref _otherAgent, value);
		}

		[Ordinal(1)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}
	}
}
