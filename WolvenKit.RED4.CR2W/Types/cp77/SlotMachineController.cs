using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotMachineController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("barrelAnimationID")] public CName BarrelAnimationID { get; set; }
		[Ordinal(2)] [RED("winAnimationsID")] public CArray<CName> WinAnimationsID { get; set; }
		[Ordinal(3)] [RED("looseAnimationID")] public CName LooseAnimationID { get; set; }
		[Ordinal(4)] [RED("slotWidgets")] public CArray<inkWidgetReference> SlotWidgets { get; set; }
		[Ordinal(5)] [RED("imagePresets")] public CArray<CName> ImagePresets { get; set; }
		[Ordinal(6)] [RED("winChance")] public CInt32 WinChance { get; set; }
		[Ordinal(7)] [RED("maxWinChance")] public CInt32 MaxWinChance { get; set; }
		[Ordinal(8)] [RED("slots")] public CArray<wCHandle<SlotMachineSlot>> Slots { get; set; }
		[Ordinal(9)] [RED("barellAnimation")] public CHandle<inkanimProxy> BarellAnimation { get; set; }
		[Ordinal(10)] [RED("outcomeAnimation")] public CHandle<inkanimProxy> OutcomeAnimation { get; set; }
		[Ordinal(11)] [RED("shouldWinNextTime")] public CBool ShouldWinNextTime { get; set; }

		public SlotMachineController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
