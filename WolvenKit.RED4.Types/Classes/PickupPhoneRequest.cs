using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PickupPhoneRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("CallInformation")] 
		public questPhoneCallInformation CallInformation
		{
			get => GetPropertyValue<questPhoneCallInformation>();
			set => SetPropertyValue<questPhoneCallInformation>(value);
		}

		public PickupPhoneRequest()
		{
			CallInformation = new();
		}
	}
}
