using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameCollisionLogic : inkWidgetLogicController
	{
		private Vector2 _colliderPositionOffset;
		private Vector2 _colliderSizeOffset;

		[Ordinal(1)] 
		[RED("colliderPositionOffset")] 
		public Vector2 ColliderPositionOffset
		{
			get
			{
				if (_colliderPositionOffset == null)
				{
					_colliderPositionOffset = (Vector2) CR2WTypeManager.Create("Vector2", "colliderPositionOffset", cr2w, this);
				}
				return _colliderPositionOffset;
			}
			set
			{
				if (_colliderPositionOffset == value)
				{
					return;
				}
				_colliderPositionOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("colliderSizeOffset")] 
		public Vector2 ColliderSizeOffset
		{
			get
			{
				if (_colliderSizeOffset == null)
				{
					_colliderSizeOffset = (Vector2) CR2WTypeManager.Create("Vector2", "colliderSizeOffset", cr2w, this);
				}
				return _colliderSizeOffset;
			}
			set
			{
				if (_colliderSizeOffset == value)
				{
					return;
				}
				_colliderSizeOffset = value;
				PropertySet(this);
			}
		}

		public gameuiSideScrollerMiniGameCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
