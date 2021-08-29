using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicStyle : ISerializable
	{
		private CArray<vgAttributeTypeValuePair> _attributes;

		[Ordinal(0)] 
		[RED("attributes")] 
		public CArray<vgAttributeTypeValuePair> Attributes
		{
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}
	}
}
