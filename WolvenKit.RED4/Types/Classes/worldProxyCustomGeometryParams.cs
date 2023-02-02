using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyCustomGeometryParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("useLimiterHelper")] 
		public CBool UseLimiterHelper
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("uvType")] 
		public CEnum<worldProxyMeshUVType> UvType
		{
			get => GetPropertyValue<CEnum<worldProxyMeshUVType>>();
			set => SetPropertyValue<CEnum<worldProxyMeshUVType>>(value);
		}

		public worldProxyCustomGeometryParams()
		{
			UvType = Enums.worldProxyMeshUVType.UvGenerateNew;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
