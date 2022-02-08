using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassemblableEntitySimple : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("collider")] 
		public CHandle<entIComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		public DisassemblableEntitySimple()
		{
			ControllerTypeName = "GenericDeviceController";
		}
	}
}
