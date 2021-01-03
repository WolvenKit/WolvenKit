using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendingMachineControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("hackCount")] public CInt32 HackCount { get; set; }
		[Ordinal(1)]  [RED("isReady")] public CBool IsReady { get; set; }
		[Ordinal(2)]  [RED("isSoldOut")] public CBool IsSoldOut { get; set; }
		[Ordinal(3)]  [RED("shopStock")] public CArray<gameSItemStack> ShopStock { get; set; }
		[Ordinal(4)]  [RED("shopStockInit")] public CBool ShopStockInit { get; set; }
		[Ordinal(5)]  [RED("soldOutProbability")] public CFloat SoldOutProbability { get; set; }
		[Ordinal(6)]  [RED("vendingMachineSFX")] public VendingMachineSFX VendingMachineSFX { get; set; }
		[Ordinal(7)]  [RED("vendingMachineSetup")] public VendingMachineSetup VendingMachineSetup { get; set; }

		public VendingMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
