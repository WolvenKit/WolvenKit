using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareSlot : BaseButtonView
	{
		private inkImageWidgetReference _iconImageRef;
		private CEnum<gamedataEquipmentArea> _slotEquipArea;
		private CInt32 _numSlots;

		[Ordinal(2)] 
		[RED("IconImageRef")] 
		public inkImageWidgetReference IconImageRef
		{
			get => GetProperty(ref _iconImageRef);
			set => SetProperty(ref _iconImageRef, value);
		}

		[Ordinal(3)] 
		[RED("SlotEquipArea")] 
		public CEnum<gamedataEquipmentArea> SlotEquipArea
		{
			get => GetProperty(ref _slotEquipArea);
			set => SetProperty(ref _slotEquipArea, value);
		}

		[Ordinal(4)] 
		[RED("NumSlots")] 
		public CInt32 NumSlots
		{
			get => GetProperty(ref _numSlots);
			set => SetProperty(ref _numSlots, value);
		}

		public CyberwareSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
