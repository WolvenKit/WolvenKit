using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimDurationFeature : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
