using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InspectDummy : gameObject
	{
		[Ordinal(35)] 
		[RED("mesh")] 
		public CHandle<entPhysicalMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(36)] 
		[RED("choice")] 
		public CHandle<gameinteractionsComponent> Choice
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("inspectComp")] 
		public CHandle<InspectableObjectComponent> InspectComp
		{
			get => GetPropertyValue<CHandle<InspectableObjectComponent>>();
			set => SetPropertyValue<CHandle<InspectableObjectComponent>>(value);
		}

		public InspectDummy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
