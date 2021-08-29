using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFacialSetup : CResource
	{
		private CResourceReference<animRig> _rig;
		private CResourceReference<animRig> _inputRig;
		private animFacialSetup_BufferInfo _info;
		private animFacialSetup_PosesBufferInfo _posesInfo;
		private DataBuffer _bakedData;
		private DataBuffer _mainPosesData;
		private DataBuffer _correctivePosesData;
		private CArray<CUInt16> _usedTransformIndices;
		private CBool _useFemaleAnimSet;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(2)] 
		[RED("inputRig")] 
		public CResourceReference<animRig> InputRig
		{
			get => GetProperty(ref _inputRig);
			set => SetProperty(ref _inputRig, value);
		}

		[Ordinal(3)] 
		[RED("info")] 
		public animFacialSetup_BufferInfo Info
		{
			get => GetProperty(ref _info);
			set => SetProperty(ref _info, value);
		}

		[Ordinal(4)] 
		[RED("posesInfo")] 
		public animFacialSetup_PosesBufferInfo PosesInfo
		{
			get => GetProperty(ref _posesInfo);
			set => SetProperty(ref _posesInfo, value);
		}

		[Ordinal(5)] 
		[RED("bakedData")] 
		public DataBuffer BakedData
		{
			get => GetProperty(ref _bakedData);
			set => SetProperty(ref _bakedData, value);
		}

		[Ordinal(6)] 
		[RED("mainPosesData")] 
		public DataBuffer MainPosesData
		{
			get => GetProperty(ref _mainPosesData);
			set => SetProperty(ref _mainPosesData, value);
		}

		[Ordinal(7)] 
		[RED("correctivePosesData")] 
		public DataBuffer CorrectivePosesData
		{
			get => GetProperty(ref _correctivePosesData);
			set => SetProperty(ref _correctivePosesData, value);
		}

		[Ordinal(8)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get => GetProperty(ref _usedTransformIndices);
			set => SetProperty(ref _usedTransformIndices, value);
		}

		[Ordinal(9)] 
		[RED("useFemaleAnimSet")] 
		public CBool UseFemaleAnimSet
		{
			get => GetProperty(ref _useFemaleAnimSet);
			set => SetProperty(ref _useFemaleAnimSet, value);
		}

		[Ordinal(10)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}
	}
}
