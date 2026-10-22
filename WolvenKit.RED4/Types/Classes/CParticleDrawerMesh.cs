using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleDrawerMesh : IParticleDrawer
	{
		[Ordinal(1)] 
		[RED("meshes")] 
		public CArray<CResourceReference<CMesh>> Meshes
		{
			get => GetPropertyValue<CArray<CResourceReference<CMesh>>>();
			set => SetPropertyValue<CArray<CResourceReference<CMesh>>>(value);
		}

		[Ordinal(2)] 
		[RED("orientationMode")] 
		public CEnum<EMeshParticleOrientationMode> OrientationMode
		{
			get => GetPropertyValue<CEnum<EMeshParticleOrientationMode>>();
			set => SetPropertyValue<CEnum<EMeshParticleOrientationMode>>(value);
		}

		[Ordinal(3)] 
		[RED("useBatchedRender")] 
		public CBool UseBatchedRender
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleDrawerMesh()
		{
			Meshes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
