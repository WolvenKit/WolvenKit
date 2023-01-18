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
			Id = 4294967295;
			InputLink = new();
			Bone = new();
			OrientationMs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
