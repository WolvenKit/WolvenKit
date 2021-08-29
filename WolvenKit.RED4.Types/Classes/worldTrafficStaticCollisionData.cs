using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficStaticCollisionData : ISerializable
	{
		private CArray<worldStaticLaneCollisions> _laneCollisions;

		[Ordinal(0)] 
		[RED("laneCollisions")] 
		public CArray<worldStaticLaneCollisions> LaneCollisions
		{
			get => GetProperty(ref _laneCollisions);
			set => SetProperty(ref _laneCollisions, value);
		}
	}
}
