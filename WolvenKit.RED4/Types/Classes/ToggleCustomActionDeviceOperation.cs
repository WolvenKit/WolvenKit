using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleCustomActionDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("customActionID")] 
		public CName CustomActionID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleCustomActionDeviceOperation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
