using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendingTerminalControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("vendingTerminalSetup")] 
		public VendingTerminalSetup VendingTerminalSetup
		{
			get => GetPropertyValue<VendingTerminalSetup>();
			set => SetPropertyValue<VendingTerminalSetup>(value);
		}

		[Ordinal(108)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetPropertyValue<CHandle<VendorDataManager>>();
			set => SetPropertyValue<CHandle<VendorDataManager>>(value);
		}

		public VendingTerminalControllerPS()
		{
			TweakDBRecord = 98928467386;
			TweakDBDescriptionRecord = 152448345865;
			VendingTerminalSetup = new VendingTerminalSetup { VendingBlacklist = new(), TimeToCompletePurchase = 3.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
