using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PickupPhoneRequest : gameScriptableSystemRequest
	{
		private questPhoneCallInformation _callInformation;

		[Ordinal(0)] 
		[RED("CallInformation")] 
		public questPhoneCallInformation CallInformation
		{
			get => GetProperty(ref _callInformation);
			set => SetProperty(ref _callInformation, value);
		}
	}
}
