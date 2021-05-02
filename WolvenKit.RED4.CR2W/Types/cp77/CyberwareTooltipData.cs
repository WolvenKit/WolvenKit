using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltipData : ATooltipData
	{
		private CString _label;
		private CArray<CHandle<CyberwareSlotTooltipData>> _slotData;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("slotData")] 
		public CArray<CHandle<CyberwareSlotTooltipData>> SlotData
		{
			get => GetProperty(ref _slotData);
			set => SetProperty(ref _slotData, value);
		}

		public CyberwareTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
