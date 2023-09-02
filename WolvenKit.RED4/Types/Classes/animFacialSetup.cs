using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialSetup : CResource
	{
		[Ordinal(1)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(2)] 
		[RED("inputRig")] 
		public CResourceReference<animRig> InputRig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(3)] 
		[RED("info")] 
		public animFacialSetup_BufferInfo Info
		{
			get => GetPropertyValue<animFacialSetup_BufferInfo>();
			set => SetPropertyValue<animFacialSetup_BufferInfo>(value);
		}

		[Ordinal(4)] 
		[RED("posesInfo")] 
		public animFacialSetup_PosesBufferInfo PosesInfo
		{
			get => GetPropertyValue<animFacialSetup_PosesBufferInfo>();
			set => SetPropertyValue<animFacialSetup_PosesBufferInfo>(value);
		}

		[Ordinal(5)] 
		[RED("bakedData")] 
		public DataBuffer BakedData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(6)] 
		[RED("mainPosesData")] 
		public DataBuffer MainPosesData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(7)] 
		[RED("correctivePosesData")] 
		public DataBuffer CorrectivePosesData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(10)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(11)] 
		[RED("useFemaleAnimSet")] 
		public CBool UseFemaleAnimSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animFacialSetup()
		{
			Info = new animFacialSetup_BufferInfo { TracksMapping = new animFacialSetup_TracksMapping(), Face = new animFacialSetup_OneSermoBufferInfo(), Eyes = new animFacialSetup_OneSermoBufferInfo(), Tongue = new animFacialSetup_OneSermoBufferInfo() };
			PosesInfo = new animFacialSetup_PosesBufferInfo { Face = new animFacialSetup_OneSermoPoseBufferInfo(), Tongue = new animFacialSetup_OneSermoPoseBufferInfo(), Eyes = new animFacialSetup_OneSermoPoseBufferInfo() };
			UsedTransformIndices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
