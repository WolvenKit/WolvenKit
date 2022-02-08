using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VentilationEffector : ActivatedDeviceTransfromAnim
	{
		[Ordinal(98)] 
		[RED("effectComponent")] 
		public CHandle<entIPlacedComponent> EffectComponent
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}
	}
}
