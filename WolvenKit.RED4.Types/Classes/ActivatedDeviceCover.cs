using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceCover : ActivatedDeviceTransfromAnim
	{
		[Ordinal(98)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}
	}
}
