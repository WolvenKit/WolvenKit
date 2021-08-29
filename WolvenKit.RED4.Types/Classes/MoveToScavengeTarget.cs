using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MoveToScavengeTarget : AIbehaviortaskScript
	{
		private CFloat _lastTime;
		private CFloat _timeout;
		private CFloat _timeoutDuration;

		[Ordinal(0)] 
		[RED("lastTime")] 
		public CFloat LastTime
		{
			get => GetProperty(ref _lastTime);
			set => SetProperty(ref _lastTime, value);
		}

		[Ordinal(1)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		[Ordinal(2)] 
		[RED("timeoutDuration")] 
		public CFloat TimeoutDuration
		{
			get => GetProperty(ref _timeoutDuration);
			set => SetProperty(ref _timeoutDuration, value);
		}
	}
}
