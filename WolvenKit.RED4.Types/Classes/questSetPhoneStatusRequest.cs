using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetPhoneStatusRequest : gameScriptableSystemRequest
	{
		private CName _status;

		[Ordinal(0)] 
		[RED("status")] 
		public CName Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}
	}
}
