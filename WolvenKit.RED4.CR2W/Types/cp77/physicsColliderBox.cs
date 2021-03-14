using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsColliderBox : physicsICollider
	{
		private Vector3 _halfExtents;
		private CBool _isObstacle;

		[Ordinal(8)] 
		[RED("halfExtents")] 
		public Vector3 HalfExtents
		{
			get
			{
				if (_halfExtents == null)
				{
					_halfExtents = (Vector3) CR2WTypeManager.Create("Vector3", "halfExtents", cr2w, this);
				}
				return _halfExtents;
			}
			set
			{
				if (_halfExtents == value)
				{
					return;
				}
				_halfExtents = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isObstacle")] 
		public CBool IsObstacle
		{
			get
			{
				if (_isObstacle == null)
				{
					_isObstacle = (CBool) CR2WTypeManager.Create("Bool", "isObstacle", cr2w, this);
				}
				return _isObstacle;
			}
			set
			{
				if (_isObstacle == value)
				{
					return;
				}
				_isObstacle = value;
				PropertySet(this);
			}
		}

		public physicsColliderBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
