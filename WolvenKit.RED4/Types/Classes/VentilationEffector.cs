using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VentilationEffector : ActivatedDeviceTransfromAnim
	{
		[Ordinal(99)] 
		[RED("effectComponent")] 
		public CHandle<entIPlacedComponent> EffectComponent
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public VentilationEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
