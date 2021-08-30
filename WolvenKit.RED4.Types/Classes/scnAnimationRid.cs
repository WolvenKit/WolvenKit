using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAnimationRid : RedBaseClass
	{
		private scnRidTag _tag;
		private CHandle<animAnimation> _animation;
		private CHandle<animEventsContainer> _events;
		private CBool _motionExtracted;
		private Transform _offset;
		private CUInt32 _bonesCount;
		private CInt32 _trajectoryBoneIndex;

		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("animation")] 
		public CHandle<animAnimation> Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(2)] 
		[RED("events")] 
		public CHandle<animEventsContainer> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		[Ordinal(3)] 
		[RED("motionExtracted")] 
		public CBool MotionExtracted
		{
			get => GetProperty(ref _motionExtracted);
			set => SetProperty(ref _motionExtracted, value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Transform Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(5)] 
		[RED("bonesCount")] 
		public CUInt32 BonesCount
		{
			get => GetProperty(ref _bonesCount);
			set => SetProperty(ref _bonesCount, value);
		}

		[Ordinal(6)] 
		[RED("trajectoryBoneIndex")] 
		public CInt32 TrajectoryBoneIndex
		{
			get => GetProperty(ref _trajectoryBoneIndex);
			set => SetProperty(ref _trajectoryBoneIndex, value);
		}

		public scnAnimationRid()
		{
			_trajectoryBoneIndex = -1;
		}
	}
}
