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
			get => GetProperty(ref _equipDataArray);
			set => SetProperty(ref _equipDataArray, value);
		}

		public FirstEquipSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
