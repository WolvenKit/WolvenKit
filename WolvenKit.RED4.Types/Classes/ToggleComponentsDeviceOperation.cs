using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleComponentsDeviceOperation : DeviceOperationBase
	{
		private CArray<SComponentOperationData> _components;

		[Ordinal(5)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}
	}
}
