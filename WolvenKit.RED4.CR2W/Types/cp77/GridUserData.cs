using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GridUserData : IScriptable
	{
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CEnum<inkEHorizontalAlign> _align;

		[Ordinal(0)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(1)] 
		[RED("align")] 
		public CEnum<inkEHorizontalAlign> Align
		{
			get => GetProperty(ref _align);
			set => SetProperty(ref _align, value);
		}

		public GridUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
