using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vgVectorGraphicShape_Polygon : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] 
		[RED("ints")] 
		public CArray<Vector2> Ints
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		public vgVectorGraphicShape_Polygon()
		{
			CalTransform = new CMatrix();
			Ints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
