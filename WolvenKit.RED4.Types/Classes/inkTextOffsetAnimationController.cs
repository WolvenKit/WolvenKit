using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTextOffsetAnimationController : inkTextAnimationController
	{
		private CFloat _timeToSkip;

		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get => GetProperty(ref _timeToSkip);
			set => SetProperty(ref _timeToSkip, value);
		}

		public inkTextOffsetAnimationController()
		{
			_timeToSkip = 0.050000F;
		}
	}
}
