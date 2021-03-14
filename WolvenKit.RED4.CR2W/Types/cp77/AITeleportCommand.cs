using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITeleportCommand : AICommand
	{
		private Vector4 _position;
		private CFloat _rotation;
		private CBool _doNavTest;

		[Ordinal(4)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (CFloat) CR2WTypeManager.Create("Float", "rotation", cr2w, this);
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

		[Ordinal(6)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get
			{
				if (_doNavTest == null)
				{
					_doNavTest = (CBool) CR2WTypeManager.Create("Bool", "doNavTest", cr2w, this);
				}
				return _doNavTest;
			}
			set
			{
				if (_doNavTest == value)
				{
					return;
				}
				_doNavTest = value;
				PropertySet(this);
			}
		}

		public AITeleportCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
