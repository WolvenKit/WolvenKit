using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleOffMeshConnectionsDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("affectsPlayer")] 
		public CBool AffectsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("affectsNPCs")] 
		public CBool AffectsNPCs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleOffMeshConnectionsDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
