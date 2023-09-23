using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PickupPhoneRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("CallInformation")] 
		public questPhoneCallInformation CallInformation
		{
			get => GetPropertyValue<questPhoneCallInformation>();
			set => SetPropertyValue<questPhoneCallInformation>(value);
		}

		[Ordinal(1)] 
		[RED("shouldBeRejected")] 
		public CBool ShouldBeRejected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PickupPhoneRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
