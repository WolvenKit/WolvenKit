using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Tetrahedron : CVariable
	{
		private Vector4 _point1;
		private Vector4 _point2;
		private Vector4 _point3;
		private Vector4 _point4;

		[Ordinal(0)] 
		[RED("point1")] 
		public Vector4 Point1
		{
			get
			{
				if (_point1 == null)
				{
					_point1 = (Vector4) CR2WTypeManager.Create("Vector4", "point1", cr2w, this);
				}
				return _point1;
			}
			set
			{
				if (_point1 == value)
				{
					return;
				}
				_point1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("point2")] 
		public Vector4 Point2
		{
			get
			{
				if (_point2 == null)
				{
					_point2 = (Vector4) CR2WTypeManager.Create("Vector4", "point2", cr2w, this);
				}
				return _point2;
			}
			set
			{
				if (_point2 == value)
				{
					return;
				}
				_point2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("point3")] 
		public Vector4 Point3
		{
			get
			{
				if (_point3 == null)
				{
					_point3 = (Vector4) CR2WTypeManager.Create("Vector4", "point3", cr2w, this);
				}
				return _point3;
			}
			set
			{
				if (_point3 == value)
				{
					return;
				}
				_point3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("point4")] 
		public Vector4 Point4
		{
			get
			{
				if (_point4 == null)
				{
					_point4 = (Vector4) CR2WTypeManager.Create("Vector4", "point4", cr2w, this);
				}
				return _point4;
			}
			set
			{
				if (_point4 == value)
				{
					return;
				}
				_point4 = value;
				PropertySet(this);
			}
		}

		public Tetrahedron(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
