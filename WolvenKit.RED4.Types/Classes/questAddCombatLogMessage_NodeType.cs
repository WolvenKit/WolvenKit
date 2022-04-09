using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAddCombatLogMessage_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("localizedMessage")] 
		public LocalizationString LocalizedMessage
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public questAddCombatLogMessage_NodeType()
		{
			LocalizedMessage = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
