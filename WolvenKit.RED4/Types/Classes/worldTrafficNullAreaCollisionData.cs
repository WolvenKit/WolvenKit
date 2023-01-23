using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficNullAreaCollisionData : ISerializable
	{
		[Ordinal(0)] 
		[RED("header")] 
		public worldCrowdNullAreaCollisionHeader Header
		{
			get => GetPropertyValue<worldCrowdNullAreaCollisionHeader>();
			set => SetPropertyValue<worldCrowdNullAreaCollisionHeader>(value);
		}

		[Ordinal(1)] 
		[RED("nullAreaCollisions")] 
		public CArray<worldCrowdNullAreaCollisionData> NullAreaCollisions
		{
			get => GetPropertyValue<CArray<worldCrowdNullAreaCollisionData>>();
			set => SetPropertyValue<CArray<worldCrowdNullAreaCollisionData>>(value);
		}

		public worldTrafficNullAreaCollisionData()
		{
			Header = new() { Direction = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity } };
			NullAreaCollisions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
