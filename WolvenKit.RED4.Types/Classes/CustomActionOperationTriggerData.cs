using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomActionOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
