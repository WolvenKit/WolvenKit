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
			get
			{
				if (_slotDataArray == null)
				{
					_slotDataArray = (CArray<gameEntitySpawnerSlotData>) CR2WTypeManager.Create("array:gameEntitySpawnerSlotData", "slotDataArray", cr2w, this);
				}
				return _slotDataArray;
			}
			set
			{
				if (_slotDataArray == value)
				{
					return;
				}
				_slotDataArray = value;
				PropertySet(this);
			}
		}

		public gameEntitySpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
