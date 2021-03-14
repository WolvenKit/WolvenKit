using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCOrientedBoxDefinition : gameinteractionsIShapeDefinition
	{
		private Vector4 _position;
		private Vector4 _forward;
		private Vector4 _right;
		private Vector4 _up;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get
			{
				if (_forward == null)
				{
					_forward = (Vector4) CR2WTypeManager.Create("Vector4", "forward", cr2w, this);
				}
				return _forward;
			}
			set
			{
				if (_forward == value)
				{
					return;
				}
				_forward = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("right")] 
		public Vector4 Right
		{
			get
			{
				if (_right == null)
				{
					_right = (Vector4) CR2WTypeManager.Create("Vector4", "right", cr2w, this);
				}
				return _right;
			}
			set
			{
				if (_right == value)
				{
					return;
				}
				_right = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("up")] 
		public Vector4 Up
		{
			get
			{
				if (_up == null)
				{
					_up = (Vector4) CR2WTypeManager.Create("Vector4", "up", cr2w, this);
				}
				return _up;
			}
			set
			{
				if (_up == value)
				{
					return;
				}
				_up = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCOrientedBoxDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
