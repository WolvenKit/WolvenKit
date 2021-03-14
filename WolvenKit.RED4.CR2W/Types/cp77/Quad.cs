using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Quad : CVariable
	{
		private Vector4 _p1;
		private Vector4 _p2;
		private Vector4 _p3;
		private Vector4 _p4;

		[Ordinal(0)] 
		[RED("p1")] 
		public Vector4 P1
		{
			get
			{
				if (_p1 == null)
				{
					_p1 = (Vector4) CR2WTypeManager.Create("Vector4", "p1", cr2w, this);
				}
				return _p1;
			}
			set
			{
				if (_p1 == value)
				{
					return;
				}
				_p1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("p2")] 
		public Vector4 P2
		{
			get
			{
				if (_p2 == null)
				{
					_p2 = (Vector4) CR2WTypeManager.Create("Vector4", "p2", cr2w, this);
				}
				return _p2;
			}
			set
			{
				if (_p2 == value)
				{
					return;
				}
				_p2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("p3")] 
		public Vector4 P3
		{
			get
			{
				if (_p3 == null)
				{
					_p3 = (Vector4) CR2WTypeManager.Create("Vector4", "p3", cr2w, this);
				}
				return _p3;
			}
			set
			{
				if (_p3 == value)
				{
					return;
				}
				_p3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("p4")] 
		public Vector4 P4
		{
			get
			{
				if (_p4 == null)
				{
					_p4 = (Vector4) CR2WTypeManager.Create("Vector4", "p4", cr2w, this);
				}
				return _p4;
			}
			set
			{
				if (_p4 == value)
				{
					return;
				}
				_p4 = value;
				PropertySet(this);
			}
		}

		public Quad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
