using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshConnectionNode : worldSplineNode
	{
		private CBool _isBidirectional;
		private CFloat _radius;
		private CEnum<worldOffMeshConnectionType> _type;
		private CArray<CName> _tags;

		[Ordinal(9)] 
		[RED("isBidirectional")] 
		public CBool IsBidirectional
		{
			get
			{
				if (_isBidirectional == null)
				{
					_isBidirectional = (CBool) CR2WTypeManager.Create("Bool", "isBidirectional", cr2w, this);
				}
				return _isBidirectional;
			}
			set
			{
				if (_isBidirectional == value)
				{
					return;
				}
				_isBidirectional = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<worldOffMeshConnectionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<worldOffMeshConnectionType>) CR2WTypeManager.Create("worldOffMeshConnectionType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public worldOffMeshConnectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
