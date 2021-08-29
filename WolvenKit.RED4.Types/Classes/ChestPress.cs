using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChestPress : InteractiveDevice
	{
		private CHandle<AnimFeature_ChestPress> _animFeatureData;
		private CName _animFeatureDataName;

		[Ordinal(97)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_ChestPress> AnimFeatureData
		{
			get => GetProperty(ref _animFeatureData);
			set => SetProperty(ref _animFeatureData, value);
		}

		[Ordinal(98)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get => GetProperty(ref _animFeatureDataName);
			set => SetProperty(ref _animFeatureDataName, value);
		}
	}
}
