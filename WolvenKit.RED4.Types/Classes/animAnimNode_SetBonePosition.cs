using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SetBonePosition : animAnimNode_OnePoseInput
	{
		private animTransformIndex _bone;
		private animVectorLink _positionMs;

		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(13)] 
		[RED("positionMs")] 
		public animVectorLink PositionMs
		{
			get => GetProperty(ref _positionMs);
			set => SetProperty(ref _positionMs, value);
		}
	}
}
