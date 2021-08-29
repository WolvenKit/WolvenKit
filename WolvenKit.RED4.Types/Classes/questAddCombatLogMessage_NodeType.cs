using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAddCombatLogMessage_NodeType : questIUIManagerNodeType
	{
		private CString _message;
		private LocalizationString _localizedMessage;

		[Ordinal(0)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(1)] 
		[RED("localizedMessage")] 
		public LocalizationString LocalizedMessage
		{
			get => GetProperty(ref _localizedMessage);
			set => SetProperty(ref _localizedMessage, value);
		}
	}
}
