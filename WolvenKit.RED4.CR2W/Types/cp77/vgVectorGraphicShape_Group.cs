using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Group : vgBaseVectorGraphicShape
	{
		private CArray<CHandle<vgBaseVectorGraphicShape>> _childShapes;

		[Ordinal(2)] 
		[RED("childShapes")] 
		public CArray<CHandle<vgBaseVectorGraphicShape>> ChildShapes
		{
			get
			{
				if (_childShapes == null)
				{
					_childShapes = (CArray<CHandle<vgBaseVectorGraphicShape>>) CR2WTypeManager.Create("array:handle:vgBaseVectorGraphicShape", "childShapes", cr2w, this);
				}
				return _childShapes;
			}
			set
			{
				if (_childShapes == value)
				{
					return;
				}
				_childShapes = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicShape_Group(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
