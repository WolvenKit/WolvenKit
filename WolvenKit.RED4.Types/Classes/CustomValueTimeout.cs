using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomValueTimeout : AITimeoutCondition
	{
		private CFloat _timeoutValue;

		[Ordinal(1)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get => GetProperty(ref _timeoutValue);
			set => SetProperty(ref _timeoutValue, value);
		}
	}
}
