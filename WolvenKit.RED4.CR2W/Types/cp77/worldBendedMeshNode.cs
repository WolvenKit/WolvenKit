using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBendedMeshNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CArray<CMatrix> _deformationData;
		private Box _deformedBox;
		private CBool _isBendedRoad;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CBool _removeFromRainMap;
		private NavGenNavigationSetting _navigationSetting;

		[Ordinal(4)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(6)] 
		[RED("deformationData")] 
		public CArray<CMatrix> DeformationData
		{
			get => GetProperty(ref _deformationData);
			set => SetProperty(ref _deformationData, value);
		}

		[Ordinal(7)] 
		[RED("deformedBox")] 
		public Box DeformedBox
		{
			get => GetProperty(ref _deformedBox);
			set => SetProperty(ref _deformedBox, value);
		}

		[Ordinal(8)] 
		[RED("isBendedRoad")] 
		public CBool IsBendedRoad
		{
			get => GetProperty(ref _isBendedRoad);
			set => SetProperty(ref _isBendedRoad, value);
		}

		[Ordinal(9)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(10)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(11)] 
		[RED("removeFromRainMap")] 
		public CBool RemoveFromRainMap
		{
			get => GetProperty(ref _removeFromRainMap);
			set => SetProperty(ref _removeFromRainMap, value);
		}

		[Ordinal(12)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetProperty(ref _navigationSetting);
			set => SetProperty(ref _navigationSetting, value);
		}

		public worldBendedMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
