using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentDebrisResourceItem : RedBaseClass
	{
		private CResourceReference<animRig> _rig;
		private CResourceReference<CMesh> _mesh;

		[Ordinal(0)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(1)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}
	}
}
