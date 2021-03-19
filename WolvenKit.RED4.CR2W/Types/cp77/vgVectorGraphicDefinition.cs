using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicDefinition : ISerializable
	{
		private CHandle<vgVectorGraphicShape_Group> _rootShapeGroup;
		private Vector2 _dimensions;

		[Ordinal(0)] 
		[RED("rootShapeGroup")] 
		public CHandle<vgVectorGraphicShape_Group> RootShapeGroup
		{
			get => GetProperty(ref _rootShapeGroup);
			set => SetProperty(ref _rootShapeGroup, value);
		}

		[Ordinal(1)] 
		[RED("dimensions")] 
		public Vector2 Dimensions
		{
			get => GetProperty(ref _dimensions);
			set => SetProperty(ref _dimensions, value);
		}

		public vgVectorGraphicDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
