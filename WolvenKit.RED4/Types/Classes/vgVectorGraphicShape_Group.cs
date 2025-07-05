using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vgVectorGraphicShape_Group : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] 
		[RED("childShapes")] 
		public CArray<CHandle<vgBaseVectorGraphicShape>> ChildShapes
		{
			get => GetPropertyValue<CArray<CHandle<vgBaseVectorGraphicShape>>>();
			set => SetPropertyValue<CArray<CHandle<vgBaseVectorGraphicShape>>>(value);
		}

		public vgVectorGraphicShape_Group()
		{
			CalTransform = new CMatrix();
			ChildShapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
