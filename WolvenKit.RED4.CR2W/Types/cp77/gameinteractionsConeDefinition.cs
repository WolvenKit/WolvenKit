using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsConeDefinition : gameinteractionsIShapeDefinition
	{
		private Vector4 _pos1;
		private Vector4 _pos2;
		private CFloat _radius1;
		private CFloat _radius2;

		[Ordinal(0)] 
		[RED("pos1")] 
		public Vector4 Pos1
		{
			get
			{
				if (_pos1 == null)
				{
					_pos1 = (Vector4) CR2WTypeManager.Create("Vector4", "pos1", cr2w, this);
				}
				return _pos1;
			}
			set
			{
				if (_pos1 == value)
				{
					return;
				}
				_pos1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pos2")] 
		public Vector4 Pos2
		{
			get
			{
				if (_pos2 == null)
				{
					_pos2 = (Vector4) CR2WTypeManager.Create("Vector4", "pos2", cr2w, this);
				}
				return _pos2;
			}
			set
			{
				if (_pos2 == value)
				{
					return;
				}
				_pos2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		public gameinteractionsConeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
