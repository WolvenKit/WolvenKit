using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsStaticCollisionShapeDebugInfo : CVariable
	{
		private CUInt64 _sourceMeshPathHash;
		private CUInt64 _prefabPathHash;
		private CUInt64 _nodeNameHash;

		[Ordinal(0)] 
		[RED("sourceMeshPathHash")] 
		public CUInt64 SourceMeshPathHash
		{
			get
			{
				if (_sourceMeshPathHash == null)
				{
					_sourceMeshPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "sourceMeshPathHash", cr2w, this);
				}
				return _sourceMeshPathHash;
			}
			set
			{
				if (_sourceMeshPathHash == value)
				{
					return;
				}
				_sourceMeshPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("prefabPathHash")] 
		public CUInt64 PrefabPathHash
		{
			get
			{
				if (_prefabPathHash == null)
				{
					_prefabPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "prefabPathHash", cr2w, this);
				}
				return _prefabPathHash;
			}
			set
			{
				if (_prefabPathHash == value)
				{
					return;
				}
				_prefabPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nodeNameHash")] 
		public CUInt64 NodeNameHash
		{
			get
			{
				if (_nodeNameHash == null)
				{
					_nodeNameHash = (CUInt64) CR2WTypeManager.Create("Uint64", "nodeNameHash", cr2w, this);
				}
				return _nodeNameHash;
			}
			set
			{
				if (_nodeNameHash == value)
				{
					return;
				}
				_nodeNameHash = value;
				PropertySet(this);
			}
		}

		public physicsStaticCollisionShapeDebugInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
