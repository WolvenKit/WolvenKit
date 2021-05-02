using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineControllerPS : ScriptableDeviceComponentPS
	{
		private VendingMachineSetup _vendingMachineSetup;
		private VendingMachineSFX _vendingMachineSFX;
		private CFloat _soldOutProbability;
		private CBool _isReady;
		private CBool _isSoldOut;
		private CInt32 _hackCount;
		private CArray<gameSItemStack> _shopStock;
		private CBool _shopStockInit;

		[Ordinal(103)] 
		[RED("vendingMachineSetup")] 
		public VendingMachineSetup VendingMachineSetup
		{
			get => GetProperty(ref _vendingMachineSetup);
			set => SetProperty(ref _vendingMachineSetup, value);
		}

		[Ordinal(104)] 
		[RED("vendingMachineSFX")] 
		public VendingMachineSFX VendingMachineSFX
		{
			get => GetProperty(ref _vendingMachineSFX);
			set => SetProperty(ref _vendingMachineSFX, value);
		}

		[Ordinal(105)] 
		[RED("soldOutProbability")] 
		public CFloat SoldOutProbability
		{
			get => GetProperty(ref _soldOutProbability);
			set => SetProperty(ref _soldOutProbability, value);
		}

		[Ordinal(106)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetProperty(ref _isReady);
			set => SetProperty(ref _isReady, value);
		}

		[Ordinal(107)] 
		[RED("isSoldOut")] 
		public CBool IsSoldOut
		{
			get => GetProperty(ref _isSoldOut);
			set => SetProperty(ref _isSoldOut, value);
		}

		[Ordinal(108)] 
		[RED("hackCount")] 
		public CInt32 HackCount
		{
			get => GetProperty(ref _hackCount);
			set => SetProperty(ref _hackCount, value);
		}

		[Ordinal(109)] 
		[RED("shopStock")] 
		public CArray<gameSItemStack> ShopStock
		{
			get => GetProperty(ref _shopStock);
			set => SetProperty(ref _shopStock, value);
		}

		[Ordinal(110)] 
		[RED("shopStockInit")] 
		public CBool ShopStockInit
		{
			get => GetProperty(ref _shopStockInit);
			set => SetProperty(ref _shopStockInit, value);
		}

		public VendingMachineControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
