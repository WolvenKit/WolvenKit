using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChestPress : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_ChestPress> AnimFeatureData
		{
			get => GetPropertyValue<CHandle<AnimFeature_ChestPress>>();
			set => SetPropertyValue<CHandle<AnimFeature_ChestPress>>(value);
		}

		[Ordinal(98)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ChestPress()
		{
			ControllerTypeName = "ChestPressController";
		}
	}
}
