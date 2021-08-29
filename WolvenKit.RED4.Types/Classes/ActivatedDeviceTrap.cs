using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceTrap : ActivatedDeviceTransfromAnim
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;

		[Ordinal(98)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}
	}
}
