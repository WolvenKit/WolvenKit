using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIUint64ArgumentInstancePS : AIArgumentInstancePS
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CUInt64 Value
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}
	}
}
