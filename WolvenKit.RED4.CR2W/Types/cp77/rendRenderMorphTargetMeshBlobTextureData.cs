using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlobTextureData : CVariable
	{
		private CStatic<Vector4> _targetDiffScale;
		private CStatic<Vector4> _targetDiffOffset;
		private CStatic<CUInt32> _targetDiffsDataOffset;
		private CStatic<CUInt32> _targetDiffsDataSize;
		private CStatic<CUInt16> _targetDiffsWidth;
		private CStatic<CUInt8> _targetDiffsMipLevelCounts;

		[Ordinal(0)] 
		[RED("targetDiffScale", 3)] 
		public CStatic<Vector4> TargetDiffScale
		{
			get
			{
				if (_targetDiffScale == null)
				{
					_targetDiffScale = (CStatic<Vector4>) CR2WTypeManager.Create("static:3,Vector4", "targetDiffScale", cr2w, this);
				}
				return _targetDiffScale;
			}
			set
			{
				if (_targetDiffScale == value)
				{
					return;
				}
				_targetDiffScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetDiffOffset", 3)] 
		public CStatic<Vector4> TargetDiffOffset
		{
			get
			{
				if (_targetDiffOffset == null)
				{
					_targetDiffOffset = (CStatic<Vector4>) CR2WTypeManager.Create("static:3,Vector4", "targetDiffOffset", cr2w, this);
				}
				return _targetDiffOffset;
			}
			set
			{
				if (_targetDiffOffset == value)
				{
					return;
				}
				_targetDiffOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetDiffsDataOffset", 3)] 
		public CStatic<CUInt32> TargetDiffsDataOffset
		{
			get
			{
				if (_targetDiffsDataOffset == null)
				{
					_targetDiffsDataOffset = (CStatic<CUInt32>) CR2WTypeManager.Create("static:3,Uint32", "targetDiffsDataOffset", cr2w, this);
				}
				return _targetDiffsDataOffset;
			}
			set
			{
				if (_targetDiffsDataOffset == value)
				{
					return;
				}
				_targetDiffsDataOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetDiffsDataSize", 3)] 
		public CStatic<CUInt32> TargetDiffsDataSize
		{
			get
			{
				if (_targetDiffsDataSize == null)
				{
					_targetDiffsDataSize = (CStatic<CUInt32>) CR2WTypeManager.Create("static:3,Uint32", "targetDiffsDataSize", cr2w, this);
				}
				return _targetDiffsDataSize;
			}
			set
			{
				if (_targetDiffsDataSize == value)
				{
					return;
				}
				_targetDiffsDataSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetDiffsWidth", 3)] 
		public CStatic<CUInt16> TargetDiffsWidth
		{
			get
			{
				if (_targetDiffsWidth == null)
				{
					_targetDiffsWidth = (CStatic<CUInt16>) CR2WTypeManager.Create("static:3,Uint16", "targetDiffsWidth", cr2w, this);
				}
				return _targetDiffsWidth;
			}
			set
			{
				if (_targetDiffsWidth == value)
				{
					return;
				}
				_targetDiffsWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetDiffsMipLevelCounts", 3)] 
		public CStatic<CUInt8> TargetDiffsMipLevelCounts
		{
			get
			{
				if (_targetDiffsMipLevelCounts == null)
				{
					_targetDiffsMipLevelCounts = (CStatic<CUInt8>) CR2WTypeManager.Create("static:3,Uint8", "targetDiffsMipLevelCounts", cr2w, this);
				}
				return _targetDiffsMipLevelCounts;
			}
			set
			{
				if (_targetDiffsMipLevelCounts == value)
				{
					return;
				}
				_targetDiffsMipLevelCounts = value;
				PropertySet(this);
			}
		}

		public rendRenderMorphTargetMeshBlobTextureData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
