using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vgVectorGraphicStyle : ISerializable
	{
		[Ordinal(0)] 
		[RED("attributes")] 
		public CArray<vgAttributeTypeValuePair> Attributes
		{
			get => GetPropertyValue<CArray<vgAttributeTypeValuePair>>();
			set => SetPropertyValue<CArray<vgAttributeTypeValuePair>>(value);
		}

		public vgVectorGraphicStyle()
		{
			Attributes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
