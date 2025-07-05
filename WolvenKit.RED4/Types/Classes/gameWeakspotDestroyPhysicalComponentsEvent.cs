using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWeakspotDestroyPhysicalComponentsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("components")] 
		public CArray<gameWeakspotPhysicalDestructionComponent> Components
		{
			get => GetPropertyValue<CArray<gameWeakspotPhysicalDestructionComponent>>();
			set => SetPropertyValue<CArray<gameWeakspotPhysicalDestructionComponent>>(value);
		}

		public gameWeakspotDestroyPhysicalComponentsEvent()
		{
			Components = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
