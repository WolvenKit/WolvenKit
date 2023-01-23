using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAnimationRid : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetPropertyValue<scnRidTag>();
			set => SetPropertyValue<scnRidTag>(value);
		}

		[Ordinal(1)] 
		[RED("animation")] 
		public CHandle<animAnimation> Animation
		{
			get => GetPropertyValue<CHandle<animAnimation>>();
			set => SetPropertyValue<CHandle<animAnimation>>(value);
		}

		[Ordinal(2)] 
		[RED("events")] 
		public CHandle<animEventsContainer> Events
		{
			get => GetPropertyValue<CHandle<animEventsContainer>>();
			set => SetPropertyValue<CHandle<animEventsContainer>>(value);
		}

		[Ordinal(3)] 
		[RED("motionExtracted")] 
		public CBool MotionExtracted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Transform Offset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(5)] 
		[RED("bonesCount")] 
		public CUInt32 BonesCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("trajectoryBoneIndex")] 
		public CInt32 TrajectoryBoneIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public scnAnimationRid()
		{
			Tag = new() { SerialNumber = new() { SerialNumber = 4294967295 } };
			Offset = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			TrajectoryBoneIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
