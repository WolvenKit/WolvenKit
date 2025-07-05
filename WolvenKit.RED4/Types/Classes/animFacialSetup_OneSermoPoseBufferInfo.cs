using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialSetup_OneSermoPoseBufferInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numMainPoses")] 
		public CUInt16 NumMainPoses
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("numCorrectivePoses")] 
		public CUInt16 NumCorrectivePoses
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("numMainTransforms")] 
		public CUInt32 NumMainTransforms
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("numMainScales")] 
		public CUInt32 NumMainScales
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("numCorrectiveTransforms")] 
		public CUInt32 NumCorrectiveTransforms
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("numCorrectiveScales")] 
		public CUInt32 NumCorrectiveScales
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animFacialSetup_OneSermoPoseBufferInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
