using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVisualCustomizationComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("storedVisualCustomizationData")] 
		public CArray<vehicleVisualCustomizationPersistentData> StoredVisualCustomizationData
		{
			get => GetPropertyValue<CArray<vehicleVisualCustomizationPersistentData>>();
			set => SetPropertyValue<CArray<vehicleVisualCustomizationPersistentData>>(value);
		}

		public vehicleVisualCustomizationComponentPS()
		{
			StoredVisualCustomizationData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
