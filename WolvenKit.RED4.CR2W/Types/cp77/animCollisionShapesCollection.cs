using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCollisionShapesCollection : ISerializable
	{
		private CArray<animCollisionRoundedShape> _collisionRoundedShapes;

		[Ordinal(0)] 
		[RED("collisionRoundedShapes")] 
		public CArray<animCollisionRoundedShape> CollisionRoundedShapes
		{
			get
			{
				if (_collisionRoundedShapes == null)
				{
					_collisionRoundedShapes = (CArray<animCollisionRoundedShape>) CR2WTypeManager.Create("array:animCollisionRoundedShape", "collisionRoundedShapes", cr2w, this);
				}
				return _collisionRoundedShapes;
			}
			set
			{
				if (_collisionRoundedShapes == value)
				{
					return;
				}
				_collisionRoundedShapes = value;
				PropertySet(this);
			}
		}

		public animCollisionShapesCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
