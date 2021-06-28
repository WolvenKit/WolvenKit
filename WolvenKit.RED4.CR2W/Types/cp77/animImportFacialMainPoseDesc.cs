using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialMainPoseDesc : CVariable
	{
		private CArray<CName> _influencedBy;
		private CArray<CUInt16> _influenceMainWeightIndices;
		private CArray<animImportFacialPoseDesc> _poses;
		private CArray<CUInt16> _poseIndices;
		private CArray<CFloat> _weights;
		private CArray<CFloat> _inBetweenScopeMultipliers;
		private CName _name;
		private CUInt16 _index;
		private CUInt8 _influenceType;
		private CUInt8 _side;
		private CUInt8 _facePart;

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
		public CArray<animImportFacialPoseDesc> Poses
		{
			get => GetProperty(ref _poses);
			set => SetProperty(ref _poses, value);
		}

		[Ordinal(3)] 
		[RED("poseIndices")] 
		public CArray<CUInt16> PoseIndices
		{
			get => GetProperty(ref _poseIndices);
			set => SetProperty(ref _poseIndices, value);
		}

		[Ordinal(4)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetProperty(ref _weights);
			set => SetProperty(ref _weights, value);
		}

		[Ordinal(5)] 
		[RED("inBetweenScopeMultipliers")] 
		public CArray<CFloat> InBetweenScopeMultipliers
		{
			get => GetProperty(ref _inBetweenScopeMultipliers);
			set => SetProperty(ref _inBetweenScopeMultipliers, value);
		}

		[Ordinal(6)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(7)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(8)] 
		[RED("influenceType")] 
		public CUInt8 InfluenceType
		{
			get => GetProperty(ref _influenceType);
			set => SetProperty(ref _influenceType, value);
		}

		[Ordinal(9)] 
		[RED("side")] 
		public CUInt8 Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}

		[Ordinal(10)] 
		[RED("facePart")] 
		public CUInt8 FacePart
		{
			get => GetProperty(ref _facePart);
			set => SetProperty(ref _facePart, value);
		}

		public animImportFacialMainPoseDesc(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
