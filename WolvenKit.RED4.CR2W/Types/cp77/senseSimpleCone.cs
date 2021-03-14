using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSimpleCone : senseIShape
	{
		private Vector4 _position1;
		private Vector4 _position2;
		private CFloat _radius1;
		private CFloat _radius2;

		[Ordinal(1)] 
		[RED("position1")] 
		public Vector4 Position1
		{
			get
			{
				if (_position1 == null)
				{
					_position1 = (Vector4) CR2WTypeManager.Create("Vector4", "position1", cr2w, this);
				}
				return _position1;
			}
			set
			{
				if (_position1 == value)
				{
					return;
				}
				_position1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("position2")] 
		public Vector4 Position2
		{
			get
			{
				if (_position2 == null)
				{
					_position2 = (Vector4) CR2WTypeManager.Create("Vector4", "position2", cr2w, this);
				}
				return _position2;
			}
			set
			{
				if (_position2 == value)
				{
					return;
				}
				_position2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radius1")] 
		public CFloat Radius1
		{
			get
			{
				if (_radius1 == null)
				{
					_radius1 = (CFloat) CR2WTypeManager.Create("Float", "radius1", cr2w, this);
				}
				return _radius1;
			}
			set
			{
				if (_radius1 == value)
				{
					return;
				}
				_radius1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("radius2")] 
		public CFloat Radius2
		{
			get
			{
				if (_radius2 == null)
				{
					_radius2 = (CFloat) CR2WTypeManager.Create("Float", "radius2", cr2w, this);
				}
				return _radius2;
			}
			set
			{
				if (_radius2 == value)
				{
					return;
				}
				_radius2 = value;
				PropertySet(this);
			}
		}

		public senseSimpleCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
