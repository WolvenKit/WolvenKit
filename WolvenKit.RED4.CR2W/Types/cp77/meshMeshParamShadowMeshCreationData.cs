using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamShadowMeshCreationData : meshMeshParameter
	{
		private CArray<CHandle<physicsICollider>> _geometries;
		private CArray<CInt32> _bonesPerGeometry;

		[Ordinal(0)] 
		[RED("geometries")] 
		public CArray<CHandle<physicsICollider>> Geometries
		{
			get => GetProperty(ref _geometries);
			set => SetProperty(ref _geometries, value);
		}

		[Ordinal(1)] 
		[RED("bonesPerGeometry")] 
		public CArray<CInt32> BonesPerGeometry
		{
			get => GetProperty(ref _bonesPerGeometry);
			set => SetProperty(ref _bonesPerGeometry, value);
		}

		public meshMeshParamShadowMeshCreationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
