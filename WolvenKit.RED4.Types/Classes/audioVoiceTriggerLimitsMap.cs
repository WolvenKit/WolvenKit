using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTriggerLimitsMap : audioAudioMetadata
	{
		private CArray<CName> _includes;
		private CArray<audioVoiceTriggerLimitsMapItem> _triggers;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetProperty(ref _includes);
			set => SetProperty(ref _includes, value);
		}

		[Ordinal(2)] 
		[RED("triggers")] 
		public CArray<audioVoiceTriggerLimitsMapItem> Triggers
		{
			get => GetProperty(ref _triggers);
			set => SetProperty(ref _triggers, value);
		}
	}
}
