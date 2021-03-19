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
			get => GetProperty(ref _targetDiffScale);
			set => SetProperty(ref _targetDiffScale, value);
		}

		[Ordinal(1)] 
		[RED("targetDiffOffset", 3)] 
		public CStatic<Vector4> TargetDiffOffset
		{
			get => GetProperty(ref _targetDiffOffset);
			set => SetProperty(ref _targetDiffOffset, value);
		}

		[Ordinal(2)] 
		[RED("targetDiffsDataOffset", 3)] 
		public CStatic<CUInt32> TargetDiffsDataOffset
		{
			get => GetProperty(ref _targetDiffsDataOffset);
			set => SetProperty(ref _targetDiffsDataOffset, value);
		}

		[Ordinal(3)] 
		[RED("targetDiffsDataSize", 3)] 
		public CStatic<CUInt32> TargetDiffsDataSize
		{
			get => GetProperty(ref _targetDiffsDataSize);
			set => SetProperty(ref _targetDiffsDataSize, value);
		}

		[Ordinal(4)] 
		[RED("targetDiffsWidth", 3)] 
		public CStatic<CUInt16> TargetDiffsWidth
		{
			get => GetProperty(ref _targetDiffsWidth);
			set => SetProperty(ref _targetDiffsWidth, value);
		}

		[Ordinal(5)] 
		[RED("targetDiffsMipLevelCounts", 3)] 
		public CStatic<CUInt8> TargetDiffsMipLevelCounts
		{
			get => GetProperty(ref _targetDiffsMipLevelCounts);
			set => SetProperty(ref _targetDiffsMipLevelCounts, value);
		}

		public rendRenderMorphTargetMeshBlobTextureData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
