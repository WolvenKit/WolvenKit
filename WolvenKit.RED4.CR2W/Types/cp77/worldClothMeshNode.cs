using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldClothMeshNode : worldMeshNode
	{
		private CBool _affectedByWind;
		private CEnum<physicsEClothCollisionMaskEnum> _collisionMask;

		[Ordinal(15)] 
		[RED("affectedByWind")] 
		public CBool AffectedByWind
		{
			get
			{
				if (_affectedByWind == null)
				{
					_affectedByWind = (CBool) CR2WTypeManager.Create("Bool", "affectedByWind", cr2w, this);
				}
				return _affectedByWind;
			}
			set
			{
				if (_affectedByWind == value)
				{
					return;
				}
				_affectedByWind = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("collisionMask")] 
		public CEnum<physicsEClothCollisionMaskEnum> CollisionMask
		{
			get
			{
				if (_collisionMask == null)
				{
					_collisionMask = (CEnum<physicsEClothCollisionMaskEnum>) CR2WTypeManager.Create("physicsEClothCollisionMaskEnum", "collisionMask", cr2w, this);
				}
				return _collisionMask;
			}
			set
			{
				if (_collisionMask == value)
				{
					return;
				}
				_collisionMask = value;
				PropertySet(this);
			}
		}

		public worldClothMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
