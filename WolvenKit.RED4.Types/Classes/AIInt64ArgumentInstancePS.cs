using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInt64ArgumentInstancePS : AIArgumentInstancePS
	{
		private CInt64 _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CInt64 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
