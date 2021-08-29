using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassemblableEntitySimple : InteractiveDevice
	{
		private CHandle<entMeshComponent> _mesh;
		private CHandle<entIComponent> _collider;

		[Ordinal(97)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(98)] 
		[RED("collider")] 
		public CHandle<entIComponent> Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}
	}
}
