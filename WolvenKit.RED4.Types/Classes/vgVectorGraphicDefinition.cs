using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicDefinition : ISerializable
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
	}
}
