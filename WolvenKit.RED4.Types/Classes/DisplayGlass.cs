using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisplayGlass : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DisplayGlass()
		{
			ControllerTypeName = "DisplayGlassController";
		}
	}
}
