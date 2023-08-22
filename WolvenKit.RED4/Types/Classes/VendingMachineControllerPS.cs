using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendingMachineControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("vendingMachineSetup")] 
		public VendingMachineSetup VendingMachineSetup
		{
			get => GetPropertyValue<VendingMachineSetup>();
			set => SetPropertyValue<VendingMachineSetup>(value);
		}

		[Ordinal(105)] 
		[RED("vendingMachineSFX")] 
		public VendingMachineSFX VendingMachineSFX
		{
			get => GetPropertyValue<VendingMachineSFX>();
			set => SetPropertyValue<VendingMachineSFX>(value);
		}

		[Ordinal(106)] 
		[RED("soldOutProbability")] 
		public CFloat SoldOutProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(107)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("isSoldOut")] 
		public CBool IsSoldOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("hackCount")] 
		public CInt32 HackCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(110)] 
		[RED("shopStock")] 
		public CArray<gameSItemStack> ShopStock
		{
			get => GetPropertyValue<CArray<gameSItemStack>>();
			set => SetPropertyValue<CArray<gameSItemStack>>(value);
		}

		[Ordinal(111)] 
		[RED("shopStockInit")] 
		public CBool ShopStockInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VendingMachineControllerPS()
		{
			DeviceName = "LocKey#176";
			TweakDBRecord = "Devices.VendingMachine";
			TweakDBDescriptionRecord = 146495886677;
			VendingMachineSetup = new VendingMachineSetup { TimeToCompletePurchase = 0.100000F };
			VendingMachineSFX = new VendingMachineSFX { GlitchingStart = "amb_int_custom_megabuilding_01_adverts_interactive_nicola_01_select_q110", GlitchingStop = "amb_int_custom_megabuilding_01_adverts_interactive_nicola_01_select_q110_stop" };
			SoldOutProbability = 0.050000F;
			IsReady = true;
			HackCount = 2;
			ShopStock = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
