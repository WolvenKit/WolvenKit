using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingSurfaceEvents : LocomotionSwimmingEvents
	{
		[Ordinal(3)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
