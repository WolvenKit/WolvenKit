using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vgVectorGraphicShape_Circle : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] 
		[RED("dius")] 
		public CFloat Dius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vgVectorGraphicShape_Circle()
		{
			CalTransform = new CMatrix();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
