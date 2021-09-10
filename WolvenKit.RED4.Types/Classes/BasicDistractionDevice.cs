using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasicDistractionDevice : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("animFeatureDataDistractor")] 
		public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor
		{
			get => GetPropertyValue<CHandle<AnimFeature_DistractionState>>();
			set => SetPropertyValue<CHandle<AnimFeature_DistractionState>>(value);
		}

		[Ordinal(98)] 
		[RED("animFeatureDataNameDistractor")] 
		public CName AnimFeatureDataNameDistractor
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(99)] 
		[RED("distractionComponentSwapNamesToON")] 
		public CArray<CName> DistractionComponentSwapNamesToON
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(100)] 
		[RED("distractionComponentSwapNamesToOFF")] 
		public CArray<CName> DistractionComponentSwapNamesToOFF
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(101)] 
		[RED("distractionComponentON")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentON
		{
			get => GetPropertyValue<CArray<CHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(102)] 
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
		}
	}
}
