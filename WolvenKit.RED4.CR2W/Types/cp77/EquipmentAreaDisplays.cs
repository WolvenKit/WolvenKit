using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentAreaDisplays : IScriptable
	{
		private CArray<CEnum<gamedataEquipmentArea>> _equipmentAreas;
		private wCHandle<inkWidget> _displaysRoot;
		private CArray<CHandle<InventoryItemDisplayController>> _displayControllers;

		[Ordinal(0)] 
		[RED("equipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipmentAreas
		{
			get => GetProperty(ref _equipmentAreas);
			set => SetProperty(ref _equipmentAreas, value);
		}

		[Ordinal(1)] 
		[RED("displaysRoot")] 
		public wCHandle<inkWidget> DisplaysRoot
		{
			get => GetProperty(ref _displaysRoot);
			set => SetProperty(ref _displaysRoot, value);
		}

		[Ordinal(2)] 
		[RED("displayControllers")] 
		public CArray<CHandle<InventoryItemDisplayController>> DisplayControllers
		{
			get => GetProperty(ref _displayControllers);
			set => SetProperty(ref _displayControllers, value);
		}

		public EquipmentAreaDisplays(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
