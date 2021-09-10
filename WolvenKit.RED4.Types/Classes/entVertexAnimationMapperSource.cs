using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVertexAnimationMapperSource : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<entVertexAnimationMapperSourceType> Type
		{
			get => GetPropertyValue<CEnum<entVertexAnimationMapperSourceType>>();
			set => SetPropertyValue<CEnum<entVertexAnimationMapperSourceType>>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
