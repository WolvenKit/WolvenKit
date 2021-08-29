using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingSurfaceFastEvents : LocomotionSwimmingEvents
	{
		private CFloat _lapsedTime;

		[Ordinal(3)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetProperty(ref _lapsedTime);
			set => SetProperty(ref _lapsedTime, value);
		}
	}
}
