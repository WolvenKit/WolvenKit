using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDebrisResourceItem : CVariable
	{
		private rRef<animRig> _rig;
		private rRef<CMesh> _mesh;

		[Ordinal(0)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(1)] 
		[RED("mesh")] 
		public rRef<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		public entdismembermentDebrisResourceItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
