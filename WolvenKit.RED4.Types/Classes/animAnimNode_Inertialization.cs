using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Inertialization : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("safeMode")] 
		public CBool SafeMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("transformsCountUpperBound")] 
		public CUInt32 TransformsCountUpperBound
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(14)] 
		[RED("tracksCountUpperBound")] 
		public CUInt32 TracksCountUpperBound
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("rotationLimits")] 
		public CArray<animInertializationRotationLimit> RotationLimits
		{
			get => GetPropertyValue<CArray<animInertializationRotationLimit>>();
			set => SetPropertyValue<CArray<animInertializationRotationLimit>>(value);
		}

		public animAnimNode_Inertialization()
		{
			Id = 4294967295;
			InputLink = new();
			SafeMode = true;
			TransformsCountUpperBound = 94;
			TracksCountUpperBound = 37;
			RotationLimits = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
