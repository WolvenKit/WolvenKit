using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldProxyMeshGroupBuildParams : RedBaseClass
	{
		private CBool _overridePrefabBuildParams;
		private worldGroupProxyMeshBuildParams _buildParams;

		[Ordinal(0)] 
		[RED("overridePrefabBuildParams")] 
		public CBool OverridePrefabBuildParams
		{
			get => GetProperty(ref _overridePrefabBuildParams);
			set => SetProperty(ref _overridePrefabBuildParams, value);
		}

		[Ordinal(1)] 
		[RED("buildParams")] 
		public worldGroupProxyMeshBuildParams BuildParams
		{
			get => GetProperty(ref _buildParams);
			set => SetProperty(ref _buildParams, value);
		}
	}
}
