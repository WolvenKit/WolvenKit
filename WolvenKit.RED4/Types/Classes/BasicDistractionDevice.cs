using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BasicDistractionDevice : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("animFeatureDataDistractor")] 
		public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor
		{
			get => GetPropertyValue<CHandle<AnimFeature_DistractionState>>();
			set => SetPropertyValue<CHandle<AnimFeature_DistractionState>>(value);
		}

		[Ordinal(95)] 
		[RED("animFeatureDataNameDistractor")] 
		public CName AnimFeatureDataNameDistractor
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(96)] 
		[RED("distractionComponentSwapNamesToON")] 
		public CArray<CName> DistractionComponentSwapNamesToON
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(97)] 
		[RED("distractionComponentSwapNamesToOFF")] 
		public CArray<CName> DistractionComponentSwapNamesToOFF
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(98)] 
		[RED("distractionComponentON")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentON
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(99)] 
		[RED("cdistractionComponentOFF")] 
		public CArray<CHandle<entIPlacedComponent>> CdistractionComponentOFF
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		public BasicDistractionDevice()
		{
			ControllerTypeName = "BasicDistractionDeviceController";
			DistractionComponentSwapNamesToON = new();
			DistractionComponentSwapNamesToOFF = new();
			DistractionComponentON = new();
			CdistractionComponentOFF = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
