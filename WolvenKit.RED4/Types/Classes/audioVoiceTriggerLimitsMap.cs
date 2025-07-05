using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceTriggerLimitsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("triggers")] 
		public CArray<audioVoiceTriggerLimitsMapItem> Triggers
		{
			get => GetPropertyValue<CArray<audioVoiceTriggerLimitsMapItem>>();
			set => SetPropertyValue<CArray<audioVoiceTriggerLimitsMapItem>>(value);
		}

		public audioVoiceTriggerLimitsMap()
		{
			Includes = new();
			Triggers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
