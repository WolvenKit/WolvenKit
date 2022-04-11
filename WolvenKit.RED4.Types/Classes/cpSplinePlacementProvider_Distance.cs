using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpSplinePlacementProvider_Distance : cpSplinePlacementProvider
	{
		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
