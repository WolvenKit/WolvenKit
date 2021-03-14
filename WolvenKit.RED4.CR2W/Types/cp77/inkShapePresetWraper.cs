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
			get
			{
				if (_shapePreset == null)
				{
					_shapePreset = (inkShapePreset) CR2WTypeManager.Create("inkShapePreset", "shapePreset", cr2w, this);
				}
				return _shapePreset;
			}
			set
			{
				if (_shapePreset == value)
				{
					return;
				}
				_shapePreset = value;
				PropertySet(this);
			}
		}

		public inkShapePresetWraper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
