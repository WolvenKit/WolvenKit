using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgAttributeTypeValuePair : ISerializable
	{
		[Ordinal(0)] 
		[RED("pe")] 
		public CEnum<vgEStyleAttributeType> Pe
		{
			get => GetPropertyValue<CEnum<vgEStyleAttributeType>>();
			set => SetPropertyValue<CEnum<vgEStyleAttributeType>>(value);
		}

		[Ordinal(1)] 
		[RED("lue")] 
		public CVariant Lue
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}
	}
}
