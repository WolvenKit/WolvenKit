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
			get
			{
				if (_overridePrefabBuildParams == null)
				{
					_overridePrefabBuildParams = (CBool) CR2WTypeManager.Create("Bool", "overridePrefabBuildParams", cr2w, this);
				}
				return _overridePrefabBuildParams;
			}
			set
			{
				if (_overridePrefabBuildParams == value)
				{
					return;
				}
				_overridePrefabBuildParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("buildParams")] 
		public worldGroupProxyMeshBuildParams BuildParams
		{
			get
			{
				if (_buildParams == null)
				{
					_buildParams = (worldGroupProxyMeshBuildParams) CR2WTypeManager.Create("worldGroupProxyMeshBuildParams", "buildParams", cr2w, this);
				}
				return _buildParams;
			}
			set
			{
				if (_buildParams == value)
				{
					return;
				}
				_buildParams = value;
				PropertySet(this);
			}
		}

		public worldProxyMeshGroupBuildParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
