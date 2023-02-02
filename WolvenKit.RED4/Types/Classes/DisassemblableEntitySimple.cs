using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisassemblableEntitySimple : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("collider")] 
		public CHandle<entIComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		public DisassemblableEntitySimple()
		{
			ControllerTypeName = "GenericDeviceController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
