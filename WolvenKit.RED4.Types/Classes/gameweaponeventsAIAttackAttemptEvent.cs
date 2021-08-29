using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponeventsAIAttackAttemptEvent : redEvent
	{
		private CWeakHandle<gameObject> _instigator;
		private CWeakHandle<gameObject> _target;
		private CBool _isWindUp;
		private CEnum<gameEContinuousMode> _continuousMode;
		private CFloat _minimumOpacity;

		[Ordinal(0)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("isWindUp")] 
		public CBool IsWindUp
		{
			get => GetProperty(ref _isWindUp);
			set => SetProperty(ref _isWindUp, value);
		}

		[Ordinal(3)] 
		[RED("continuousMode")] 
		public CEnum<gameEContinuousMode> ContinuousMode
		{
			get => GetProperty(ref _continuousMode);
			set => SetProperty(ref _continuousMode, value);
		}

		[Ordinal(4)] 
		[RED("minimumOpacity")] 
		public CFloat MinimumOpacity
		{
			get => GetProperty(ref _minimumOpacity);
			set => SetProperty(ref _minimumOpacity, value);
		}
	}
}
