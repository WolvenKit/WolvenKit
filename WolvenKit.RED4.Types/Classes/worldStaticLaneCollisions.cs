using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticLaneCollisions : RedBaseClass
	{
		private worldTrafficLaneUID _lane;
		private CArray<worldTrafficStaticCollisionSphere> _collisions;
		private CFloat _deadEndStart;

		[Ordinal(0)] 
		[RED("lane")] 
		public worldTrafficLaneUID Lane
		{
			get => GetProperty(ref _lane);
			set => SetProperty(ref _lane, value);
		}

		[Ordinal(1)] 
		[RED("collisions")] 
		public CArray<worldTrafficStaticCollisionSphere> Collisions
		{
			get => GetProperty(ref _collisions);
			set => SetProperty(ref _collisions, value);
		}

		[Ordinal(2)] 
		[RED("deadEndStart")] 
		public CFloat DeadEndStart
		{
			get => GetProperty(ref _deadEndStart);
			set => SetProperty(ref _deadEndStart, value);
		}
	}
}
