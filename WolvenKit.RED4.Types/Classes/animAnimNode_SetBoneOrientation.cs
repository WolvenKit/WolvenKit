using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SetBoneOrientation : animAnimNode_OnePoseInput
	{
		private animTransformIndex _bone;
		private animQuaternionLink _orientationMs;

		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(13)] 
		[RED("orientationMs")] 
		public animQuaternionLink OrientationMs
		{
			get => GetProperty(ref _orientationMs);
			set => SetProperty(ref _orientationMs, value);
		}
	}
}
