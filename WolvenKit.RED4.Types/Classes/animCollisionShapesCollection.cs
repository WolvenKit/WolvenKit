using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCollisionShapesCollection : ISerializable
	{
		[Ordinal(0)] 
		[RED("collisionRoundedShapes")] 
		public CArray<animCollisionRoundedShape> CollisionRoundedShapes
		{
			get => GetPropertyValue<CArray<animCollisionRoundedShape>>();
			set => SetPropertyValue<CArray<animCollisionRoundedShape>>(value);
		}

		public animCollisionShapesCollection()
		{
			CollisionRoundedShapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
