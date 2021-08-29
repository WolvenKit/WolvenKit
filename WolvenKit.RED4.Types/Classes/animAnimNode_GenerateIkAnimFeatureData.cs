using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_GenerateIkAnimFeatureData : animAnimNode_OnePoseInput
	{
		private CArray<animIKChainSettings> _ikChainSettings;

		[Ordinal(12)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get => GetProperty(ref _ikChainSettings);
			set => SetProperty(ref _ikChainSettings, value);
		}
	}
}
