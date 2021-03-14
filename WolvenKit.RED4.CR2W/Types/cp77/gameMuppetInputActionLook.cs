using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionLook : gameIMuppetInputAction
	{
		private Vector2 _rotation;

		[Ordinal(0)] 
		[RED("rotation")] 
		public Vector2 Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (Vector2) CR2WTypeManager.Create("Vector2", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		public gameMuppetInputActionLook(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
