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
			get
			{
				if (_label == null)
				{
					_label = (CString) CR2WTypeManager.Create("String", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotData")] 
		public CArray<CHandle<CyberwareSlotTooltipData>> SlotData
		{
			get
			{
				if (_slotData == null)
				{
					_slotData = (CArray<CHandle<CyberwareSlotTooltipData>>) CR2WTypeManager.Create("array:handle:CyberwareSlotTooltipData", "slotData", cr2w, this);
				}
				return _slotData;
			}
			set
			{
				if (_slotData == value)
				{
					return;
				}
				_slotData = value;
				PropertySet(this);
			}
		}

		public CyberwareTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
