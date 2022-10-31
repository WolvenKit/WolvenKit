using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WardrobeControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("clothingSets")] 
		public CArray<CHandle<gameClothingSet>> ClothingSets
		{
			get => GetPropertyValue<CArray<CHandle<gameClothingSet>>>();
			set => SetPropertyValue<CArray<CHandle<gameClothingSet>>>(value);
		}

		[Ordinal(105)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WardrobeControllerPS()
		{
			DeviceName = "LocKey#2120";
			TweakDBRecord = 70419249436;
			ShouldScannerShowStatus = false;
			ShouldScannerShowNetwork = false;
			ClothingSets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
