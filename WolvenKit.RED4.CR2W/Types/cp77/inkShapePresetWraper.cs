using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkShapePresetWraper : ISerializable
	{
		private inkShapePreset _shapePreset;

		[Ordinal(0)] 
		[RED("shapePreset")] 
		public inkShapePreset ShapePreset
		{
			get => GetProperty(ref _shapePreset);
			set => SetProperty(ref _shapePreset, value);
		}

		public inkShapePresetWraper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
