using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystem : gameScriptableSystem
	{
		private CArray<CHandle<EquipmentSystemPlayerData>> _ownerData;

		[Ordinal(0)] 
		[RED("ownerData")] 
		public CArray<CHandle<EquipmentSystemPlayerData>> OwnerData
		{
			get => GetProperty(ref _ownerData);
			set => SetProperty(ref _ownerData, value);
		}

		public EquipmentSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
