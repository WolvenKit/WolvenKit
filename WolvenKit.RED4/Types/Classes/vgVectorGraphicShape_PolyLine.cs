using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vgVectorGraphicShape_PolyLine : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] 
		[RED("ints")] 
		public CArray<Vector2> Ints
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		[Ordinal(3)] 
		[RED("roke")] 
		public CFloat Roke
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vgVectorGraphicShape_PolyLine()
		{
			CalTransform = new CMatrix();
			Ints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
