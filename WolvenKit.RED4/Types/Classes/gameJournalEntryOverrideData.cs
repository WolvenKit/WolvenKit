using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalEntryOverrideData : IScriptable
	{
		[Ordinal(0)] 
		[RED("inputDevice")] 
		public CEnum<inputESimplifiedInputDevice> InputDevice
		{
			get => GetPropertyValue<CEnum<inputESimplifiedInputDevice>>();
			set => SetPropertyValue<CEnum<inputESimplifiedInputDevice>>(value);
		}

		[Ordinal(1)] 
		[RED("inputScheme")] 
		public CEnum<inputEInputScheme> InputScheme
		{
			get => GetPropertyValue<CEnum<inputEInputScheme>>();
			set => SetPropertyValue<CEnum<inputEInputScheme>>(value);
		}

		[Ordinal(2)] 
		[RED("overriddenLocalizationString")] 
		public LocalizationString OverriddenLocalizationString
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalEntryOverrideData()
		{
			OverriddenLocalizationString = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
