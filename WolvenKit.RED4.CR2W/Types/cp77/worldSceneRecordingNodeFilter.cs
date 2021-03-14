using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingNodeFilter : CVariable
	{
		private CFloat _streamInNodesWithStreamingDistanceMoreThan;
		private CFloat _streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan;
		private CBool _meshNodesOnly;
		private worldSceneRecordingNodeMeshResourceFilter _meshResourceFilter;

		[Ordinal(0)] 
		[RED("streamInNodesWithStreamingDistanceMoreThan")] 
		public CFloat StreamInNodesWithStreamingDistanceMoreThan
		{
			get
			{
				if (_streamInNodesWithStreamingDistanceMoreThan == null)
				{
					_streamInNodesWithStreamingDistanceMoreThan = (CFloat) CR2WTypeManager.Create("Float", "streamInNodesWithStreamingDistanceMoreThan", cr2w, this);
				}
				return _streamInNodesWithStreamingDistanceMoreThan;
			}
			set
			{
				if (_streamInNodesWithStreamingDistanceMoreThan == value)
				{
					return;
				}
				_streamInNodesWithStreamingDistanceMoreThan = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan")] 
		public CFloat StreamOutPrefabProxyMeshesWithStreamingDistanceMoreThan
		{
			get
			{
				if (_streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan == null)
				{
					_streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan = (CFloat) CR2WTypeManager.Create("Float", "streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan", cr2w, this);
				}
				return _streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan;
			}
			set
			{
				if (_streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan == value)
				{
					return;
				}
				_streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("meshNodesOnly")] 
		public CBool MeshNodesOnly
		{
			get
			{
				if (_meshNodesOnly == null)
				{
					_meshNodesOnly = (CBool) CR2WTypeManager.Create("Bool", "meshNodesOnly", cr2w, this);
				}
				return _meshNodesOnly;
			}
			set
			{
				if (_meshNodesOnly == value)
				{
					return;
				}
				_meshNodesOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("meshResourceFilter")] 
		public worldSceneRecordingNodeMeshResourceFilter MeshResourceFilter
		{
			get
			{
				if (_meshResourceFilter == null)
				{
					_meshResourceFilter = (worldSceneRecordingNodeMeshResourceFilter) CR2WTypeManager.Create("worldSceneRecordingNodeMeshResourceFilter", "meshResourceFilter", cr2w, this);
				}
				return _meshResourceFilter;
			}
			set
			{
				if (_meshResourceFilter == value)
				{
					return;
				}
				_meshResourceFilter = value;
				PropertySet(this);
			}
		}

		public worldSceneRecordingNodeFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
