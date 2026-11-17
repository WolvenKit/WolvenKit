using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FootStepScaling : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("hipsIndex")] 
		public animTransformIndex HipsIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("leftFootIKIndex")] 
		public animTransformIndex LeftFootIKIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("rightFootIKIndex")] 
		public animTransformIndex RightFootIKIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("inputSpeed")] 
		public animFloatLink InputSpeed
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(6)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(7)] 
		[RED("Params")] 
		public animfssBodyOfflineParams Params
		{
			get => GetPropertyValue<animfssBodyOfflineParams>();
			set => SetPropertyValue<animfssBodyOfflineParams>(value);
		}

		public animAnimNode_FootStepScaling()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			HipsIndex = new animTransformIndex();
			LeftFootIKIndex = new animTransformIndex();
			RightFootIKIndex = new animTransformIndex();
			InputSpeed = new animFloatLink();
			Weight = new animFloatLink();
			Params = new animfssBodyOfflineParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
