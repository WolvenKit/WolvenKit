using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redConvexHullEx : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}
	}
}
