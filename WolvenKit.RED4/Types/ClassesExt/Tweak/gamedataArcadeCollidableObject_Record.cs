
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeCollidableObject_Record
	{
		[RED("boundingShapeRelativeArea")]
		[REDProperty(IsIgnored = true)]
		public Vector2 BoundingShapeRelativeArea
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
	}
}
