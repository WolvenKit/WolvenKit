using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChestPress : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_ChestPress> AnimFeatureData
		{
			get => GetPropertyValue<CHandle<AnimFeature_ChestPress>>();
			set => SetPropertyValue<CHandle<AnimFeature_ChestPress>>(value);
		}

		[Ordinal(95)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ChestPress()
		{
			ControllerTypeName = "ChestPressController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
