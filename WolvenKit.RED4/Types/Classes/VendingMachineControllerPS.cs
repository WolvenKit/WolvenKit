using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendingMachineControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("vendingMachineSetup")] 
		public VendingMachineSetup VendingMachineSetup
		{
			get => GetPropertyValue<VendingMachineSetup>();
			set => SetPropertyValue<VendingMachineSetup>(value);
		}

		[Ordinal(108)] 
		[RED("vendingMachineSFX")] 
		public VendingMachineSFX VendingMachineSFX
		{
			get => GetPropertyValue<VendingMachineSFX>();
			set => SetPropertyValue<VendingMachineSFX>(value);
		}

		[Ordinal(109)] 
		[RED("soldOutProbability")] 
		public CFloat SoldOutProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("isSoldOut")] 
		public CBool IsSoldOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("hackCount")] 
		public CInt32 HackCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(113)] 
		[RED("shopStock")] 
		public CArray<gameSItemStack> ShopStock
		{
			get => GetPropertyValue<CArray<gameSItemStack>>();
			set => SetPropertyValue<CArray<gameSItemStack>>(value);
		}

		[Ordinal(114)] 
		[RED("shopStockInit")] 
		public CBool ShopStockInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VendingMachineControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
