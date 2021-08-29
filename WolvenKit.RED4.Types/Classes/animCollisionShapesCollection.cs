using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animCollisionShapesCollection : ISerializable
	{
		private CArray<animCollisionRoundedShape> _collisionRoundedShapes;

		[Ordinal(0)] 
		[RED("collisionRoundedShapes")] 
		public CArray<animCollisionRoundedShape> CollisionRoundedShapes
		{
			get => GetProperty(ref _collisionRoundedShapes);
			set => SetProperty(ref _collisionRoundedShapes, value);
		}
	}
}
