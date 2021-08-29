using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealNetworkRequestRequest : gameScriptableSystemRequest
	{
		private entEntityID _target;
		private CFloat _delay;
		private CBool _nextFrame;

		[Ordinal(0)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(2)] 
		[RED("nextFrame")] 
		public CBool NextFrame
		{
			get => GetProperty(ref _nextFrame);
			set => SetProperty(ref _nextFrame, value);
		}
	}
}
