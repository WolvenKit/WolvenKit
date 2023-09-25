using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeshAppearanceDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public MeshAppearanceDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
