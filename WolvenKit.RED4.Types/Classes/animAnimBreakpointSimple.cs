using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimBreakpointSimple : animIAnimBreakpoint
	{
		[Ordinal(1)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
