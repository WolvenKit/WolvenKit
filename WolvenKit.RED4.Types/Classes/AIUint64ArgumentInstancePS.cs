using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIUint64ArgumentInstancePS : AIArgumentInstancePS
	{
		private CUInt64 _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CUInt64 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
