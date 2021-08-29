using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CharParamTimeout : AITimeoutCondition
	{
		private CString _timeoutParamName;

		[Ordinal(1)] 
		[RED("timeoutParamName")] 
		public CString TimeoutParamName
		{
			get => GetProperty(ref _timeoutParamName);
			set => SetProperty(ref _timeoutParamName, value);
		}
	}
}
