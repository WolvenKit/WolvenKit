using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetReactionPreset : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("recordSelector")] 
		public CHandle<questReactionPresetRecordSelector> RecordSelector
		{
			get => GetPropertyValue<CHandle<questReactionPresetRecordSelector>>();
			set => SetPropertyValue<CHandle<questReactionPresetRecordSelector>>(value);
		}

		public questCharacterManagerParameters_SetReactionPreset()
		{
			PuppetRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
