using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResponseEvent : redEvent
	{
		private CHandle<IScriptable> _responseData;

		[Ordinal(0)] 
		[RED("responseData")] 
		public CHandle<IScriptable> ResponseData
		{
			get => GetProperty(ref _responseData);
			set => SetProperty(ref _responseData, value);
		}
	}
}
