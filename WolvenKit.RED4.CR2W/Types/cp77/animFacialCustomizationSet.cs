using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialCustomizationSet : CResource
	{
		private rRef<animFacialSetup> _baseSetup;
		private CArray<raRef<animFacialSetup>> _targetSetups;
		private CArray<animFacialCustomizationTargetEntryTemp> _targetSetupsTemp;
		private CUInt32 _numTargets;
		private animFacialSetup_PosesBufferInfo _posesInfo;
		private CArray<CUInt8> _jointRegions;
		private DataBuffer _mainPosesData;
		private CArray<CUInt16> _usedTransformIndices;
		private DataBuffer _correctivePosesData;
		private CUInt32 _numJoints;
		private DataBuffer _rigReferencePosesData;
		private CBool _isCooked;

		[Ordinal(1)] 
		[RED("baseSetup")] 
		public rRef<animFacialSetup> BaseSetup
		{
			get => GetProperty(ref _baseSetup);
			set => SetProperty(ref _baseSetup, value);
		}

		[Ordinal(2)] 
		[RED("targetSetups")] 
		public CArray<raRef<animFacialSetup>> TargetSetups
		{
			get => GetProperty(ref _targetSetups);
			set => SetProperty(ref _targetSetups, value);
		}

		[Ordinal(3)] 
		[RED("targetSetupsTemp")] 
		public CArray<animFacialCustomizationTargetEntryTemp> TargetSetupsTemp
		{
			get => GetProperty(ref _targetSetupsTemp);
			set => SetProperty(ref _targetSetupsTemp, value);
		}

		[Ordinal(4)] 
		[RED("numTargets")] 
		public CUInt32 NumTargets
		{
			get => GetProperty(ref _numTargets);
			set => SetProperty(ref _numTargets, value);
		}

		[Ordinal(5)] 
		[RED("posesInfo")] 
		public animFacialSetup_PosesBufferInfo PosesInfo
		{
			get => GetProperty(ref _posesInfo);
			set => SetProperty(ref _posesInfo, value);
		}

		[Ordinal(6)] 
		[RED("jointRegions")] 
		public CArray<CUInt8> JointRegions
		{
			get => GetProperty(ref _jointRegions);
			set => SetProperty(ref _jointRegions, value);
		}

		[Ordinal(7)] 
		[RED("mainPosesData")] 
		public DataBuffer MainPosesData
		{
			get => GetProperty(ref _mainPosesData);
			set => SetProperty(ref _mainPosesData, value);
		}

		[Ordinal(8)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get => GetProperty(ref _usedTransformIndices);
			set => SetProperty(ref _usedTransformIndices, value);
		}

		[Ordinal(9)] 
		[RED("correctivePosesData")] 
		public DataBuffer CorrectivePosesData
		{
			get => GetProperty(ref _correctivePosesData);
			set => SetProperty(ref _correctivePosesData, value);
		}

		[Ordinal(10)] 
		[RED("numJoints")] 
		public CUInt32 NumJoints
		{
			get => GetProperty(ref _numJoints);
			set => SetProperty(ref _numJoints, value);
		}

		[Ordinal(11)] 
		[RED("rigReferencePosesData")] 
		public DataBuffer RigReferencePosesData
		{
			get => GetProperty(ref _rigReferencePosesData);
			set => SetProperty(ref _rigReferencePosesData, value);
		}

		[Ordinal(12)] 
		[RED("isCooked")] 
		public CBool IsCooked
		{
			get => GetProperty(ref _isCooked);
			set => SetProperty(ref _isCooked, value);
		}

		public animFacialCustomizationSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
