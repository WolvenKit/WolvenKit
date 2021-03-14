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
			get
			{
				if (_vendingMachineSetup == null)
				{
					_vendingMachineSetup = (VendingMachineSetup) CR2WTypeManager.Create("VendingMachineSetup", "vendingMachineSetup", cr2w, this);
				}
				return _vendingMachineSetup;
			}
			set
			{
				if (_vendingMachineSetup == value)
				{
					return;
				}
				_vendingMachineSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("vendingMachineSFX")] 
		public VendingMachineSFX VendingMachineSFX
		{
			get
			{
				if (_vendingMachineSFX == null)
				{
					_vendingMachineSFX = (VendingMachineSFX) CR2WTypeManager.Create("VendingMachineSFX", "vendingMachineSFX", cr2w, this);
				}
				return _vendingMachineSFX;
			}
			set
			{
				if (_vendingMachineSFX == value)
				{
					return;
				}
				_vendingMachineSFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("soldOutProbability")] 
		public CFloat SoldOutProbability
		{
			get
			{
				if (_soldOutProbability == null)
				{
					_soldOutProbability = (CFloat) CR2WTypeManager.Create("Float", "soldOutProbability", cr2w, this);
				}
				return _soldOutProbability;
			}
			set
			{
				if (_soldOutProbability == value)
				{
					return;
				}
				_soldOutProbability = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get
			{
				if (_isReady == null)
				{
					_isReady = (CBool) CR2WTypeManager.Create("Bool", "isReady", cr2w, this);
				}
				return _isReady;
			}
			set
			{
				if (_isReady == value)
				{
					return;
				}
				_isReady = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("isSoldOut")] 
		public CBool IsSoldOut
		{
			get
			{
				if (_isSoldOut == null)
				{
					_isSoldOut = (CBool) CR2WTypeManager.Create("Bool", "isSoldOut", cr2w, this);
				}
				return _isSoldOut;
			}
			set
			{
				if (_isSoldOut == value)
				{
					return;
				}
				_isSoldOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("hackCount")] 
		public CInt32 HackCount
		{
			get
			{
				if (_hackCount == null)
				{
					_hackCount = (CInt32) CR2WTypeManager.Create("Int32", "hackCount", cr2w, this);
				}
				return _hackCount;
			}
			set
			{
				if (_hackCount == value)
				{
					return;
				}
				_hackCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("shopStock")] 
		public CArray<gameSItemStack> ShopStock
		{
			get
			{
				if (_shopStock == null)
				{
					_shopStock = (CArray<gameSItemStack>) CR2WTypeManager.Create("array:gameSItemStack", "shopStock", cr2w, this);
				}
				return _shopStock;
			}
			set
			{
				if (_shopStock == value)
				{
					return;
				}
				_shopStock = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("shopStockInit")] 
		public CBool ShopStockInit
		{
			get
			{
				if (_shopStockInit == null)
				{
					_shopStockInit = (CBool) CR2WTypeManager.Create("Bool", "shopStockInit", cr2w, this);
				}
				return _shopStockInit;
			}
			set
			{
				if (_shopStockInit == value)
				{
					return;
				}
				_shopStockInit = value;
				PropertySet(this);
			}
		}

		public VendingMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
