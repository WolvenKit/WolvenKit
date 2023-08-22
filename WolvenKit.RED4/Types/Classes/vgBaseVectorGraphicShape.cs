using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class vgBaseVectorGraphicShape : ISerializable
	{
		[Ordinal(0)] 
		[RED("calTransform")] 
		public CMatrix CalTransform
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		[Ordinal(1)] 
		[RED("yle")] 
		public CHandle<vgVectorGraphicStyle> Yle
		{
			get => GetPropertyValue<CHandle<vgVectorGraphicStyle>>();
			set => SetPropertyValue<CHandle<vgVectorGraphicStyle>>(value);
		}

		public vgBaseVectorGraphicShape()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
