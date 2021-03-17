using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPaperdollEquipData : CVariable
	{
		private gameSEquipArea _equipArea;
		private CInt32 _slotIndex;
		private TweakDBID _placementSlot;
		private CBool _equipped;

		[Ordinal(0)] 
		[RED("equipArea")] 
		public gameSEquipArea EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(1)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(2)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetProperty(ref _placementSlot);
			set => SetProperty(ref _placementSlot, value);
		}

		[Ordinal(3)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get => GetProperty(ref _equipped);
			set => SetProperty(ref _equipped, value);
		}

		public SPaperdollEquipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
