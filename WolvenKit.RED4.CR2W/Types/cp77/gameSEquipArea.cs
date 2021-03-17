using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSEquipArea : CVariable
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CArray<gameSEquipSlot> _equipSlots;
		private CInt32 _activeIndex;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(1)] 
		[RED("equipSlots")] 
		public CArray<gameSEquipSlot> EquipSlots
		{
			get => GetProperty(ref _equipSlots);
			set => SetProperty(ref _equipSlots, value);
		}

		[Ordinal(2)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetProperty(ref _activeIndex);
			set => SetProperty(ref _activeIndex, value);
		}

		public gameSEquipArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
