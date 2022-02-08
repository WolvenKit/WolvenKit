using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpPlayerDetector : gameObject
	{
		[Ordinal(40)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public cpPlayerDetector()
		{
			Range = 10.000000F;
		}
	}
}
