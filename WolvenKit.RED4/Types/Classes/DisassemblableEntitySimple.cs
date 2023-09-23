using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisassemblableEntitySimple : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("collider")] 
		public CHandle<entIComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		public DisassemblableEntitySimple()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
