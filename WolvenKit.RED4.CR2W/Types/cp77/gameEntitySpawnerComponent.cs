using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerComponent : gameComponent
	{
		private CArray<gameEntitySpawnerSlotData> _slotDataArray;

		[Ordinal(4)] 
		[RED("slotDataArray")] 
		public CArray<gameEntitySpawnerSlotData> SlotDataArray
		{
			get => GetProperty(ref _slotDataArray);
			set => SetProperty(ref _slotDataArray, value);
		}

		public gameEntitySpawnerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
