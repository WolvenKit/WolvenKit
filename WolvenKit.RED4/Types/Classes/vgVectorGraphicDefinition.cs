using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vgVectorGraphicDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("rootShapeGroup")] 
		public CHandle<vgVectorGraphicShape_Group> RootShapeGroup
		{
			get => GetPropertyValue<CHandle<vgVectorGraphicShape_Group>>();
			set => SetPropertyValue<CHandle<vgVectorGraphicShape_Group>>(value);
		}

		[Ordinal(1)] 
		[RED("dimensions")] 
		public Vector2 Dimensions
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public vgVectorGraphicDefinition()
		{
			Dimensions = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
