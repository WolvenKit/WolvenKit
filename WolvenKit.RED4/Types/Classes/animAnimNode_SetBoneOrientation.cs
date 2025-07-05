using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetBoneOrientation : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("orientationMs")] 
		public animQuaternionLink OrientationMs
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		public animAnimNode_SetBoneOrientation()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			Bone = new animTransformIndex();
			OrientationMs = new animQuaternionLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
