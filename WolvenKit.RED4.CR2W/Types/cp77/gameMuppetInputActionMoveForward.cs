using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionMoveForward : gameIMuppetInputAction
	{
		private Vector2 _direction;
		private CBool _isSprinting;

		[Ordinal(0)] 
		[RED("direction")] 
		public Vector2 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (Vector2) CR2WTypeManager.Create("Vector2", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isSprinting")] 
		public CBool IsSprinting
		{
			get
			{
				if (_isSprinting == null)
				{
					_isSprinting = (CBool) CR2WTypeManager.Create("Bool", "isSprinting", cr2w, this);
				}
				return _isSprinting;
			}
			set
			{
				if (_isSprinting == value)
				{
					return;
				}
				_isSprinting = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputActionMoveForward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
