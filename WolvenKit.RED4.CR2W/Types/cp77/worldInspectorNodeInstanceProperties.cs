using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInspectorNodeInstanceProperties : ISerializable
	{
		private worldCompiledNodeInstanceSetupInfo _setupInfo;
		private CHandle<worldMeshNode> _meshNode;
		private CHandle<worldInstancedMeshNode> _instancedMeshNode;
		private CFloat _lastObserverDistanceToStreamingPoint;
		private CFloat _lastObserverDistanceToSecondaryReferencePoint;
		private CUInt64 _renderProxyAddressForDebug;

		[Ordinal(0)] 
		[RED("setupInfo")] 
		public worldCompiledNodeInstanceSetupInfo SetupInfo
		{
			get
			{
				if (_setupInfo == null)
				{
					_setupInfo = (worldCompiledNodeInstanceSetupInfo) CR2WTypeManager.Create("worldCompiledNodeInstanceSetupInfo", "setupInfo", cr2w, this);
				}
				return _setupInfo;
			}
			set
			{
				if (_setupInfo == value)
				{
					return;
				}
				_setupInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("meshNode")] 
		public CHandle<worldMeshNode> MeshNode
		{
			get
			{
				if (_meshNode == null)
				{
					_meshNode = (CHandle<worldMeshNode>) CR2WTypeManager.Create("handle:worldMeshNode", "meshNode", cr2w, this);
				}
				return _meshNode;
			}
			set
			{
				if (_meshNode == value)
				{
					return;
				}
				_meshNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instancedMeshNode")] 
		public CHandle<worldInstancedMeshNode> InstancedMeshNode
		{
			get
			{
				if (_instancedMeshNode == null)
				{
					_instancedMeshNode = (CHandle<worldInstancedMeshNode>) CR2WTypeManager.Create("handle:worldInstancedMeshNode", "instancedMeshNode", cr2w, this);
				}
				return _instancedMeshNode;
			}
			set
			{
				if (_instancedMeshNode == value)
				{
					return;
				}
				_instancedMeshNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lastObserverDistanceToStreamingPoint")] 
		public CFloat LastObserverDistanceToStreamingPoint
		{
			get
			{
				if (_lastObserverDistanceToStreamingPoint == null)
				{
					_lastObserverDistanceToStreamingPoint = (CFloat) CR2WTypeManager.Create("Float", "lastObserverDistanceToStreamingPoint", cr2w, this);
				}
				return _lastObserverDistanceToStreamingPoint;
			}
			set
			{
				if (_lastObserverDistanceToStreamingPoint == value)
				{
					return;
				}
				_lastObserverDistanceToStreamingPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lastObserverDistanceToSecondaryReferencePoint")] 
		public CFloat LastObserverDistanceToSecondaryReferencePoint
		{
			get
			{
				if (_lastObserverDistanceToSecondaryReferencePoint == null)
				{
					_lastObserverDistanceToSecondaryReferencePoint = (CFloat) CR2WTypeManager.Create("Float", "lastObserverDistanceToSecondaryReferencePoint", cr2w, this);
				}
				return _lastObserverDistanceToSecondaryReferencePoint;
			}
			set
			{
				if (_lastObserverDistanceToSecondaryReferencePoint == value)
				{
					return;
				}
				_lastObserverDistanceToSecondaryReferencePoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("renderProxyAddressForDebug")] 
		public CUInt64 RenderProxyAddressForDebug
		{
			get
			{
				if (_renderProxyAddressForDebug == null)
				{
					_renderProxyAddressForDebug = (CUInt64) CR2WTypeManager.Create("Uint64", "renderProxyAddressForDebug", cr2w, this);
				}
				return _renderProxyAddressForDebug;
			}
			set
			{
				if (_renderProxyAddressForDebug == value)
				{
					return;
				}
				_renderProxyAddressForDebug = value;
				PropertySet(this);
			}
		}

		public worldInspectorNodeInstanceProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
