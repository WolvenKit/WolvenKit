using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleCustomMultilayer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("onlyForPlayerVehicleAppearances")] 
		public CArray<CName> OnlyForPlayerVehicleAppearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("affectedComponents")] 
		public CArray<CName> AffectedComponents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("excludedComponents")] 
		public CArray<CName> ExcludedComponents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("customMlSetup")] 
		public redResourceReferenceScriptToken CustomMlSetup
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(4)] 
		[RED("customMlMask")] 
		public redResourceReferenceScriptToken CustomMlMask
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(5)] 
		[RED("coatLayerMin")] 
		public CFloat CoatLayerMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("coatLayerMax")] 
		public CFloat CoatLayerMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleVehicleCustomMultilayer()
		{
			OnlyForPlayerVehicleAppearances = new();
			AffectedComponents = new();
			ExcludedComponents = new();
			CustomMlSetup = new redResourceReferenceScriptToken();
			CustomMlMask = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
