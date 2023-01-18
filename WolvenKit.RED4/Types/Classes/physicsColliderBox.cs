using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsColliderBox : physicsICollider
	{
		[Ordinal(8)] 
		[RED("halfExtents")] 
		public Vector3 HalfExtents
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("isObstacle")] 
		public CBool IsObstacle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public physicsColliderBox()
		{
			LocalToBody = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			MaterialApperanceOverrides = new();
			VolumeModifier = 1.000000F;
			HalfExtents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
