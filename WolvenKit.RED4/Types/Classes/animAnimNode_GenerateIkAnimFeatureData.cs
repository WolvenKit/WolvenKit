using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_GenerateIkAnimFeatureData : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get => GetPropertyValue<CArray<animIKChainSettings>>();
			set => SetPropertyValue<CArray<animIKChainSettings>>(value);
		}

		public animAnimNode_GenerateIkAnimFeatureData()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			IkChainSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
