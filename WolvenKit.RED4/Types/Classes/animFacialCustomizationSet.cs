using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialCustomizationSet : CResource
	{
		[Ordinal(1)] 
		[RED("baseSetup")] 
		public CResourceReference<animFacialSetup> BaseSetup
		{
			get => GetPropertyValue<CResourceReference<animFacialSetup>>();
			set => SetPropertyValue<CResourceReference<animFacialSetup>>(value);
		}

		[Ordinal(2)] 
		[RED("targetSetups")] 
		public CArray<CResourceAsyncReference<animFacialSetup>> TargetSetups
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<animFacialSetup>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<animFacialSetup>>>(value);
		}

		[Ordinal(3)] 
		[RED("targetSetupsTemp")] 
		public CArray<animFacialCustomizationTargetEntryTemp> TargetSetupsTemp
		{
			get => GetPropertyValue<CArray<animFacialCustomizationTargetEntryTemp>>();
			set => SetPropertyValue<CArray<animFacialCustomizationTargetEntryTemp>>(value);
		}

		[Ordinal(4)] 
		[RED("numTargets")] 
		public CUInt32 NumTargets
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("posesInfo")] 
		public animFacialSetup_PosesBufferInfo PosesInfo
		{
			get => GetPropertyValue<animFacialSetup_PosesBufferInfo>();
			set => SetPropertyValue<animFacialSetup_PosesBufferInfo>(value);
		}

		[Ordinal(6)] 
		[RED("jointRegions")] 
		public CArray<CUInt8> JointRegions
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(7)] 
		[RED("mainPosesData")] 
		public DataBuffer MainPosesData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(8)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(9)] 
		[RED("correctivePosesData")] 
		public DataBuffer CorrectivePosesData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(10)] 
		[RED("numJoints")] 
		public CUInt32 NumJoints
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("rigReferencePosesData")] 
		public DataBuffer RigReferencePosesData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(12)] 
		[RED("isCooked")] 
		public CBool IsCooked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animFacialCustomizationSet()
		{
			TargetSetups = new();
			TargetSetupsTemp = new();
			PosesInfo = new animFacialSetup_PosesBufferInfo { Face = new animFacialSetup_OneSermoPoseBufferInfo(), Tongue = new animFacialSetup_OneSermoPoseBufferInfo(), Eyes = new animFacialSetup_OneSermoPoseBufferInfo() };
			JointRegions = new();
			UsedTransformIndices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
