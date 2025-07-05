using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BasicDistractionDevice : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("animFeatureDataDistractor")] 
		public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor
		{
			get => GetPropertyValue<CHandle<AnimFeature_DistractionState>>();
			set => SetPropertyValue<CHandle<AnimFeature_DistractionState>>(value);
		}

		[Ordinal(99)] 
		[RED("animFeatureDataNameDistractor")] 
		public CName AnimFeatureDataNameDistractor
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(100)] 
		[RED("distractionComponentSwapNamesToON")] 
		public CArray<CName> DistractionComponentSwapNamesToON
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(101)] 
		[RED("distractionComponentSwapNamesToOFF")] 
		public CArray<CName> DistractionComponentSwapNamesToOFF
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(102)] 
		[RED("distractionComponentON")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentON
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(103)] 
		[RED("distractionComponentOFF")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentOFF
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(104)] 
		[RED("meshAppearanceNameON")] 
		public CName MeshAppearanceNameON
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(105)] 
		[RED("meshAppearanceNameOFF")] 
		public CName MeshAppearanceNameOFF
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BasicDistractionDevice()
		{
			ControllerTypeName = "BasicDistractionDeviceController";
			DistractionComponentSwapNamesToON = new();
			DistractionComponentSwapNamesToOFF = new();
			DistractionComponentON = new();
			DistractionComponentOFF = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
