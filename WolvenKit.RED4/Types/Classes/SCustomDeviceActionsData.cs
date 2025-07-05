using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SCustomDeviceActionsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actions")] 
		public CArray<SDeviceActionCustomData> Actions
		{
			get => GetPropertyValue<CArray<SDeviceActionCustomData>>();
			set => SetPropertyValue<CArray<SDeviceActionCustomData>>(value);
		}

		public SCustomDeviceActionsData()
		{
			Actions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
