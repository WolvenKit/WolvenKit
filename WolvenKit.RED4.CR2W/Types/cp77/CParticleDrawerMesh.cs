using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerMesh : IParticleDrawer
	{
		private CArray<rRef<CMesh>> _meshes;
		private CEnum<EMeshParticleOrientationMode> _orientationMode;

		[Ordinal(1)] 
		[RED("meshes")] 
		public CArray<rRef<CMesh>> Meshes
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

		public CParticleDrawerMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
