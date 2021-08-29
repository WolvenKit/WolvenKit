using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SafeAction : animAnimFeature
	{
		private CBool _triggerHeld;
		private CBool _inCover;
		private CFloat _safeActionDuration;

		[Ordinal(0)] 
		[RED("triggerHeld")] 
		public CBool TriggerHeld
		{
			get => GetProperty(ref _triggerHeld);
			set => SetProperty(ref _triggerHeld, value);
		}

		[Ordinal(1)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get => GetProperty(ref _inCover);
			set => SetProperty(ref _inCover, value);
		}

		[Ordinal(2)] 
		[RED("safeActionDuration")] 
		public CFloat SafeActionDuration
		{
			get => GetProperty(ref _safeActionDuration);
			set => SetProperty(ref _safeActionDuration, value);
		}
	}
}
