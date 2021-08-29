using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VentilationEffector : ActivatedDeviceTransfromAnim
	{
		private CHandle<entIPlacedComponent> _effectComponent;

		[Ordinal(98)] 
		[RED("effectComponent")] 
		public CHandle<entIPlacedComponent> EffectComponent
		{
			get => GetProperty(ref _effectComponent);
			set => SetProperty(ref _effectComponent, value);
		}
	}
}
