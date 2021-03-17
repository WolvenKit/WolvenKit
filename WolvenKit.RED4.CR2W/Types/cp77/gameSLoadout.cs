using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSLoadout : CVariable
	{
		private CArray<gameSEquipArea> _equipAreas;
		private CArray<gameSEquipmentSet> _equipmentSets;

		[Ordinal(0)] 
		[RED("equipAreas")] 
		public CArray<gameSEquipArea> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		[Ordinal(1)] 
		[RED("equipmentSets")] 
		public CArray<gameSEquipmentSet> EquipmentSets
		{
			get => GetProperty(ref _equipmentSets);
			set => SetProperty(ref _equipmentSets, value);
		}

		public gameSLoadout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
