using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendingMachineControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("vendingMachineSetup")] public VendingMachineSetup VendingMachineSetup { get; set; }
		[Ordinal(104)] [RED("vendingMachineSFX")] public VendingMachineSFX VendingMachineSFX { get; set; }
		[Ordinal(105)] [RED("soldOutProbability")] public CFloat SoldOutProbability { get; set; }
		[Ordinal(106)] [RED("isReady")] public CBool IsReady { get; set; }
		[Ordinal(107)] [RED("isSoldOut")] public CBool IsSoldOut { get; set; }
		[Ordinal(108)] [RED("hackCount")] public CInt32 HackCount { get; set; }
		[Ordinal(109)] [RED("shopStock")] public CArray<gameSItemStack> ShopStock { get; set; }
		[Ordinal(110)] [RED("shopStockInit")] public CBool ShopStockInit { get; set; }

		public VendingMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
