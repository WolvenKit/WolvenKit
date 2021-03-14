using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FirstEquipSystem : gameScriptableSystem
	{
		private CArray<EFirstEquipData> _equipDataArray;

		[Ordinal(0)] 
		[RED("equipDataArray")] 
		public CArray<EFirstEquipData> EquipDataArray
		{
			get
			{
				if (_equipDataArray == null)
				{
					_equipDataArray = (CArray<EFirstEquipData>) CR2WTypeManager.Create("array:EFirstEquipData", "equipDataArray", cr2w, this);
				}
				return _equipDataArray;
			}
			set
			{
				if (_equipDataArray == value)
				{
					return;
				}
				_equipDataArray = value;
				PropertySet(this);
			}
		}

		public FirstEquipSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
