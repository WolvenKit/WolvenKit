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
			get => GetProperty(ref _occluderType);
			set => SetProperty(ref _occluderType, value);
		}

		[Ordinal(5)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(6)] 
		[RED("autohideDistanceScale")] 
		public CUInt8 AutohideDistanceScale
		{
			get => GetProperty(ref _autohideDistanceScale);
			set => SetProperty(ref _autohideDistanceScale, value);
		}

		[Ordinal(7)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		public worldStaticOccluderMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
