using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CharParamTimeout : AITimeoutCondition
	{
		[Ordinal(1)] 
		[RED("timeoutParamName")] 
		public CString TimeoutParamName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
