using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVisualCustomizationComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("storedAppliedVisualCustomization")] 
		public CArray<VehicleCustomTemplatePersistentData> StoredAppliedVisualCustomization
		{
			get => GetPropertyValue<CArray<VehicleCustomTemplatePersistentData>>();
			set => SetPropertyValue<CArray<VehicleCustomTemplatePersistentData>>(value);
		}

		[Ordinal(1)] 
		[RED("storedGenericVisualCustomizationTemplates")] 
		public CArray<GenericTemplatePersistentData> StoredGenericVisualCustomizationTemplates
		{
			get => GetPropertyValue<CArray<GenericTemplatePersistentData>>();
			set => SetPropertyValue<CArray<GenericTemplatePersistentData>>(value);
		}

		[Ordinal(2)] 
		[RED("storedUniqueVisualCustomizationTemplates")] 
		public CArray<VehicleUniqueTemplatePersistentData> StoredUniqueVisualCustomizationTemplates
		{
			get => GetPropertyValue<CArray<VehicleUniqueTemplatePersistentData>>();
			set => SetPropertyValue<CArray<VehicleUniqueTemplatePersistentData>>(value);
		}

		[Ordinal(3)] 
		[RED("storedVisualCustomizationData")] 
		public CArray<vehicleVisualCustomizationPersistentData> StoredVisualCustomizationData
		{
			get => GetPropertyValue<CArray<vehicleVisualCustomizationPersistentData>>();
			set => SetPropertyValue<CArray<vehicleVisualCustomizationPersistentData>>(value);
		}

		public vehicleVisualCustomizationComponentPS()
		{
			StoredAppliedVisualCustomization = new();
			StoredGenericVisualCustomizationTemplates = new();
			StoredUniqueVisualCustomizationTemplates = new();
			StoredVisualCustomizationData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
