using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomValueTimeout : AITimeoutCondition
	{
		[Ordinal(1)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
