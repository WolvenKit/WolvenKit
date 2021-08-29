using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldProxyCustomGeometryParams : RedBaseClass
	{
		private CBool _useLimiterHelper;
		private CEnum<worldProxyMeshUVType> _uvType;

		[Ordinal(0)] 
		[RED("useLimiterHelper")] 
		public CBool UseLimiterHelper
		{
			get => GetProperty(ref _useLimiterHelper);
			set => SetProperty(ref _useLimiterHelper, value);
		}

		[Ordinal(1)] 
		[RED("uvType")] 
		public CEnum<worldProxyMeshUVType> UvType
		{
			get => GetProperty(ref _uvType);
			set => SetProperty(ref _uvType, value);
		}
	}
}
