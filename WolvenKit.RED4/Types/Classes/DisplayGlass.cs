using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisplayGlass : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("mesh")] 
		public CHandle<entIPlacedComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DisplayGlass()
		{
			ControllerTypeName = "DisplayGlassController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
