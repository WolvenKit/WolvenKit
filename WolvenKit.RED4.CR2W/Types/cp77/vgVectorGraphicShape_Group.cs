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
			get => GetProperty(ref _childShapes);
			set => SetProperty(ref _childShapes, value);
		}

		public vgVectorGraphicShape_Group(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
