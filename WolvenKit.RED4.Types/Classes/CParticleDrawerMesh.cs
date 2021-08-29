using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleDrawerMesh : IParticleDrawer
	{
		private CArray<CResourceReference<CMesh>> _meshes;
		private CEnum<EMeshParticleOrientationMode> _orientationMode;

		[Ordinal(1)] 
		[RED("meshes")] 
		public CArray<CResourceReference<CMesh>> Meshes
		{
			get => GetProperty(ref _meshes);
			set => SetProperty(ref _meshes, value);
		}

		[Ordinal(2)] 
		[RED("orientationMode")] 
		public CEnum<EMeshParticleOrientationMode> OrientationMode
		{
			get => GetProperty(ref _orientationMode);
			set => SetProperty(ref _orientationMode, value);
		}
	}
}
