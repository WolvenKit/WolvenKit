using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficStaticCollisionData : ISerializable
	{
		[Ordinal(0)] 
		[RED("laneCollisions")] 
		public CArray<worldStaticLaneCollisions> LaneCollisions
		{
			get => GetPropertyValue<CArray<worldStaticLaneCollisions>>();
			set => SetPropertyValue<CArray<worldStaticLaneCollisions>>(value);
		}

		public worldTrafficStaticCollisionData()
		{
			LaneCollisions = new();
		}
	}
}
