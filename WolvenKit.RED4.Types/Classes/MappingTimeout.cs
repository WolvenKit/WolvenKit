using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MappingTimeout : AITimeoutCondition
	{
		private CHandle<AIArgumentMapping> _timeoutMapping;
		private CFloat _timeoutValue;

		[Ordinal(1)] 
		[RED("timeoutMapping")] 
		public CHandle<AIArgumentMapping> TimeoutMapping
		{
			get => GetProperty(ref _timeoutMapping);
			set => SetProperty(ref _timeoutMapping, value);
		}

		[Ordinal(2)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get => GetProperty(ref _timeoutValue);
			set => SetProperty(ref _timeoutValue, value);
		}
	}
}
