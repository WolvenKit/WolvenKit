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
			get
			{
				if (_meshes == null)
				{
					_meshes = (CArray<rRef<CMesh>>) CR2WTypeManager.Create("array:rRef:CMesh", "meshes", cr2w, this);
				}
				return _meshes;
			}
			set
			{
				if (_meshes == value)
				{
					return;
				}
				_meshes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("orientationMode")] 
		public CEnum<EMeshParticleOrientationMode> OrientationMode
		{
			get
			{
				if (_orientationMode == null)
				{
					_orientationMode = (CEnum<EMeshParticleOrientationMode>) CR2WTypeManager.Create("EMeshParticleOrientationMode", "orientationMode", cr2w, this);
				}
				return _orientationMode;
			}
			set
			{
				if (_orientationMode == value)
				{
					return;
				}
				_orientationMode = value;
				PropertySet(this);
			}
		}

		public CParticleDrawerMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
