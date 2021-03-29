using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassemblableEntitySimple : InteractiveDevice
	{
		private CHandle<entMeshComponent> _mesh;
		private CHandle<entIComponent> _collider;

		[Ordinal(96)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(97)] 
		[RED("collider")] 
		public CHandle<entIComponent> Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		public DisassemblableEntitySimple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
