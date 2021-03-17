using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialCorrectivePoseDesc : CVariable
	{
		private CArray<CName> _influencedBy;
		private CArray<CUInt16> _influenceMainWeightIndices;
		private CArray<animImportFacialCorrectivePoseDataDesc> _poses;
		private CArray<CInt16> _parentsInBetweenIndices;
		private CArray<CUInt16> _parentIndices;
		private CName _name;
		private CUInt16 _index;
		private CUInt8 _influencedBySpeed;
		private CUInt8 _poseType;
		private CUInt8 _poseLOD;
		private CArray<CFloat> _weights;
		private CArray<CFloat> _inBetweenScopeMultipliers;
		private CBool _linearCorrection;
		private CBool _useGlobalWeight;

		[Ordinal(0)] 
		[RED("influencedBy")] 
		public CArray<CName> InfluencedBy
		{
			get => GetProperty(ref _influencedBy);
			set => SetProperty(ref _influencedBy, value);
		}

		[Ordinal(1)] 
		[RED("influenceMainWeightIndices")] 
		public CArray<CUInt16> InfluenceMainWeightIndices
		{
			get => GetProperty(ref _influenceMainWeightIndices);
			set => SetProperty(ref _influenceMainWeightIndices, value);
		}

		[Ordinal(2)] 
		[RED("poses")] 
		public CArray<animImportFacialCorrectivePoseDataDesc> Poses
		{
			get => GetProperty(ref _poses);
			set => SetProperty(ref _poses, value);
		}

		[Ordinal(3)] 
		[RED("parentsInBetweenIndices")] 
		public CArray<CInt16> ParentsInBetweenIndices
		{
			get => GetProperty(ref _parentsInBetweenIndices);
			set => SetProperty(ref _parentsInBetweenIndices, value);
		}

		[Ordinal(4)] 
		[RED("parentIndices")] 
		public CArray<CUInt16> ParentIndices
		{
			get => GetProperty(ref _parentIndices);
			set => SetProperty(ref _parentIndices, value);
		}

		[Ordinal(5)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(6)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(7)] 
		[RED("influencedBySpeed")] 
		public CUInt8 InfluencedBySpeed
		{
			get => GetProperty(ref _influencedBySpeed);
			set => SetProperty(ref _influencedBySpeed, value);
		}

		[Ordinal(8)] 
		[RED("poseType")] 
		public CUInt8 PoseType
		{
			get => GetProperty(ref _poseType);
			set => SetProperty(ref _poseType, value);
		}

		[Ordinal(9)] 
		[RED("poseLOD")] 
		public CUInt8 PoseLOD
		{
			get => GetProperty(ref _poseLOD);
			set => SetProperty(ref _poseLOD, value);
		}

		[Ordinal(10)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetProperty(ref _weights);
			set => SetProperty(ref _weights, value);
		}

		[Ordinal(11)] 
		[RED("inBetweenScopeMultipliers")] 
		public CArray<CFloat> InBetweenScopeMultipliers
		{
			get => GetProperty(ref _inBetweenScopeMultipliers);
			set => SetProperty(ref _inBetweenScopeMultipliers, value);
		}

		[Ordinal(12)] 
		[RED("linearCorrection")] 
		public CBool LinearCorrection
		{
			get => GetProperty(ref _linearCorrection);
			set => SetProperty(ref _linearCorrection, value);
		}

		[Ordinal(13)] 
		[RED("useGlobalWeight")] 
		public CBool UseGlobalWeight
		{
			get => GetProperty(ref _useGlobalWeight);
			set => SetProperty(ref _useGlobalWeight, value);
		}

		public animImportFacialCorrectivePoseDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
