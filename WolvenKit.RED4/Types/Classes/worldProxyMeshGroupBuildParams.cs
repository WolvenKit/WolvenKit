using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyMeshGroupBuildParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("overridePrefabBuildParams")] 
		public CBool OverridePrefabBuildParams
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("buildParams")] 
		public worldGroupProxyMeshBuildParams BuildParams
		{
			get => GetPropertyValue<worldGroupProxyMeshBuildParams>();
			set => SetPropertyValue<worldGroupProxyMeshBuildParams>(value);
		}

		public worldProxyMeshGroupBuildParams()
		{
			BuildParams = new worldGroupProxyMeshBuildParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
