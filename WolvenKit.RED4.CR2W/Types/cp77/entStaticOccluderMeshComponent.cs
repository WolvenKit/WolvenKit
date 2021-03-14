using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entStaticOccluderMeshComponent : entIPlacedComponent
	{
		private rRef<CMesh> _mesh;
		private Vector3 _scale;
		private CColor _color;
		private CEnum<visWorldOccluderType> _occluderType;
		private CUInt8 _occluderAutohideDistanceScale;

		[Ordinal(5)] 
		[RED("mesh")] 
		public rRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (rRef<CMesh>) CR2WTypeManager.Create("rRef:CMesh", "mesh", cr2w, this);
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

		[Ordinal(6)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector3) CR2WTypeManager.Create("Vector3", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("occluderAutohideDistanceScale")] 
		public CUInt8 OccluderAutohideDistanceScale
		{
			get
			{
				if (_occluderAutohideDistanceScale == null)
				{
					_occluderAutohideDistanceScale = (CUInt8) CR2WTypeManager.Create("Uint8", "occluderAutohideDistanceScale", cr2w, this);
				}
				return _occluderAutohideDistanceScale;
			}
			set
			{
				if (_occluderAutohideDistanceScale == value)
				{
					return;
				}
				_occluderAutohideDistanceScale = value;
				PropertySet(this);
			}
		}

		public entStaticOccluderMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
