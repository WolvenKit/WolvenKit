using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticOccluderMeshNode : worldNode
	{
		private CEnum<visWorldOccluderType> _occluderType;
		private CColor _color;
		private CUInt8 _autohideDistanceScale;
		private raRef<CMesh> _mesh;

		[Ordinal(4)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get
			{
				if (_occluderType == null)
				{
					_occluderType = (CEnum<visWorldOccluderType>) CR2WTypeManager.Create("visWorldOccluderType", "occluderType", cr2w, this);
				}
				return _occluderType;
			}
			set
			{
				if (_occluderType == value)
				{
					return;
				}
				_occluderType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("autohideDistanceScale")] 
		public CUInt8 AutohideDistanceScale
		{
			get
			{
				if (_autohideDistanceScale == null)
				{
					_autohideDistanceScale = (CUInt8) CR2WTypeManager.Create("Uint8", "autohideDistanceScale", cr2w, this);
				}
				return _autohideDistanceScale;
			}
			set
			{
				if (_autohideDistanceScale == value)
				{
					return;
				}
				_autohideDistanceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		public worldStaticOccluderMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
