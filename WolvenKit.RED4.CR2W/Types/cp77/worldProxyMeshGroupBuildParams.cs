using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyMeshGroupBuildParams : CVariable
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

		public worldProxyMeshGroupBuildParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
