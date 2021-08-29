using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerParameters_SetReactionPreset : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CHandle<questReactionPresetRecordSelector> _recordSelector;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("recordSelector")] 
		public CHandle<questReactionPresetRecordSelector> RecordSelector
		{
			get => GetProperty(ref _recordSelector);
			set => SetProperty(ref _recordSelector, value);
		}
	}
}
