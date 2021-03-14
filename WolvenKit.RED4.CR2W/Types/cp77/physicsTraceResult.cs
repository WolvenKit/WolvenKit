using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsTraceResult : CVariable
	{
		private Vector3 _position;
		private Vector3 _normal;
		private CName _material;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
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
		[RED("normal")] 
		public Vector3 Normal
		{
			get
			{
				if (_normal == null)
				{
					_normal = (Vector3) CR2WTypeManager.Create("Vector3", "normal", cr2w, this);
				}
				return _normal;
			}
			set
			{
				if (_normal == value)
				{
					return;
				}
				_normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("material")] 
		public CName Material
		{
			get
			{
				if (_material == null)
				{
					_material = (CName) CR2WTypeManager.Create("CName", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		public physicsTraceResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
