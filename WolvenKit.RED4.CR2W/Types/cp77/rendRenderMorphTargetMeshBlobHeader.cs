using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlobHeader : CVariable
	{
		private CUInt32 _version;
		private CUInt32 _numDiffs;
		private CUInt32 _numDiffsMapping;
		private CUInt32 _numTargets;
		private CArray<CUInt32> _targetStartsInVertexDiffs;
		private CArray<CUInt32> _targetStartsInVertexDiffsMapping;
		private CArray<Vector4> _targetPositionDiffScale;
		private CArray<Vector4> _targetPositionDiffOffset;
		private CArray<CArray<CUInt32>> _numVertexDiffsInEachChunk;
		private CArray<CArray<CUInt32>> _numVertexDiffsMappingInEachChunk;
		private CArray<rendRenderMorphTargetMeshBlobTextureData> _targetTextureDiffsData;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numDiffs")] 
		public CUInt32 NumDiffs
		{
			get
			{
				if (_numDiffs == null)
				{
					_numDiffs = (CUInt32) CR2WTypeManager.Create("Uint32", "numDiffs", cr2w, this);
				}
				return _numDiffs;
			}
			set
			{
				if (_numDiffs == value)
				{
					return;
				}
				_numDiffs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numDiffsMapping")] 
		public CUInt32 NumDiffsMapping
		{
			get
			{
				if (_numDiffsMapping == null)
				{
					_numDiffsMapping = (CUInt32) CR2WTypeManager.Create("Uint32", "numDiffsMapping", cr2w, this);
				}
				return _numDiffsMapping;
			}
			set
			{
				if (_numDiffsMapping == value)
				{
					return;
				}
				_numDiffsMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numTargets")] 
		public CUInt32 NumTargets
		{
			get
			{
				if (_numTargets == null)
				{
					_numTargets = (CUInt32) CR2WTypeManager.Create("Uint32", "numTargets", cr2w, this);
				}
				return _numTargets;
			}
			set
			{
				if (_numTargets == value)
				{
					return;
				}
				_numTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetStartsInVertexDiffs")] 
		public CArray<CUInt32> TargetStartsInVertexDiffs
		{
			get
			{
				if (_targetStartsInVertexDiffs == null)
				{
					_targetStartsInVertexDiffs = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "targetStartsInVertexDiffs", cr2w, this);
				}
				return _targetStartsInVertexDiffs;
			}
			set
			{
				if (_targetStartsInVertexDiffs == value)
				{
					return;
				}
				_targetStartsInVertexDiffs = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetStartsInVertexDiffsMapping")] 
		public CArray<CUInt32> TargetStartsInVertexDiffsMapping
		{
			get
			{
				if (_targetStartsInVertexDiffsMapping == null)
				{
					_targetStartsInVertexDiffsMapping = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "targetStartsInVertexDiffsMapping", cr2w, this);
				}
				return _targetStartsInVertexDiffsMapping;
			}
			set
			{
				if (_targetStartsInVertexDiffsMapping == value)
				{
					return;
				}
				_targetStartsInVertexDiffsMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targetPositionDiffScale")] 
		public CArray<Vector4> TargetPositionDiffScale
		{
			get
			{
				if (_targetPositionDiffScale == null)
				{
					_targetPositionDiffScale = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "targetPositionDiffScale", cr2w, this);
				}
				return _targetPositionDiffScale;
			}
			set
			{
				if (_targetPositionDiffScale == value)
				{
					return;
				}
				_targetPositionDiffScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("targetPositionDiffOffset")] 
		public CArray<Vector4> TargetPositionDiffOffset
		{
			get
			{
				if (_targetPositionDiffOffset == null)
				{
					_targetPositionDiffOffset = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "targetPositionDiffOffset", cr2w, this);
				}
				return _targetPositionDiffOffset;
			}
			set
			{
				if (_targetPositionDiffOffset == value)
				{
					return;
				}
				_targetPositionDiffOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("numVertexDiffsInEachChunk")] 
		public CArray<CArray<CUInt32>> NumVertexDiffsInEachChunk
		{
			get
			{
				if (_numVertexDiffsInEachChunk == null)
				{
					_numVertexDiffsInEachChunk = (CArray<CArray<CUInt32>>) CR2WTypeManager.Create("array:array:Uint32", "numVertexDiffsInEachChunk", cr2w, this);
				}
				return _numVertexDiffsInEachChunk;
			}
			set
			{
				if (_numVertexDiffsInEachChunk == value)
				{
					return;
				}
				_numVertexDiffsInEachChunk = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("numVertexDiffsMappingInEachChunk")] 
		public CArray<CArray<CUInt32>> NumVertexDiffsMappingInEachChunk
		{
			get
			{
				if (_numVertexDiffsMappingInEachChunk == null)
				{
					_numVertexDiffsMappingInEachChunk = (CArray<CArray<CUInt32>>) CR2WTypeManager.Create("array:array:Uint32", "numVertexDiffsMappingInEachChunk", cr2w, this);
				}
				return _numVertexDiffsMappingInEachChunk;
			}
			set
			{
				if (_numVertexDiffsMappingInEachChunk == value)
				{
					return;
				}
				_numVertexDiffsMappingInEachChunk = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("targetTextureDiffsData")] 
		public CArray<rendRenderMorphTargetMeshBlobTextureData> TargetTextureDiffsData
		{
			get
			{
				if (_targetTextureDiffsData == null)
				{
					_targetTextureDiffsData = (CArray<rendRenderMorphTargetMeshBlobTextureData>) CR2WTypeManager.Create("array:rendRenderMorphTargetMeshBlobTextureData", "targetTextureDiffsData", cr2w, this);
				}
				return _targetTextureDiffsData;
			}
			set
			{
				if (_targetTextureDiffsData == value)
				{
					return;
				}
				_targetTextureDiffsData = value;
				PropertySet(this);
			}
		}

		public rendRenderMorphTargetMeshBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
