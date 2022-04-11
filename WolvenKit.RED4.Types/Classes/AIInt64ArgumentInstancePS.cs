using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInt64ArgumentInstancePS : AIArgumentInstancePS
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CInt64 Value
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}
	}
}
