using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpSplinePlacementProvider_Count : cpSplinePlacementProvider_Distance
	{
		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
