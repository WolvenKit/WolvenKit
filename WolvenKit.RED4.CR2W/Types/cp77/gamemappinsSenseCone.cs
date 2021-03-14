using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsSenseCone : CVariable
	{
		private CFloat _length;
		private CFloat _width;
		private CFloat _angleDegrees;
		private Vector4 _position1;
		private Vector4 _position2;

		[Ordinal(0)] 
		[RED("length")] 
		public CFloat Length
		{
			get
			{
				if (_length == null)
				{
					_length = (CFloat) CR2WTypeManager.Create("Float", "length", cr2w, this);
				}
				return _length;
			}
			set
			{
				if (_length == value)
				{
					return;
				}
				_length = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("angleDegrees")] 
		public CFloat AngleDegrees
		{
			get
			{
				if (_angleDegrees == null)
				{
					_angleDegrees = (CFloat) CR2WTypeManager.Create("Float", "angleDegrees", cr2w, this);
				}
				return _angleDegrees;
			}
			set
			{
				if (_angleDegrees == value)
				{
					return;
				}
				_angleDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public gamemappinsSenseCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
