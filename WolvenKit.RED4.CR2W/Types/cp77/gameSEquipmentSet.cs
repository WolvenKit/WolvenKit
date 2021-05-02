using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSEquipmentSet : CVariable
	{
		private CArray<gameSItemInfo> _setItems;
		private CName _setName;
		private CEnum<gameEquipmentSetType> _setType;

		[Ordinal(0)] 
		[RED("setItems")] 
		public CArray<gameSItemInfo> SetItems
		{
			get => GetProperty(ref _setItems);
			set => SetProperty(ref _setItems, value);
		}

		[Ordinal(1)] 
		[RED("setName")] 
		public CName SetName
		{
			get => GetProperty(ref _setName);
			set => SetProperty(ref _setName, value);
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get => GetProperty(ref _setType);
			set => SetProperty(ref _setType, value);
		}

		public gameSEquipmentSet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
