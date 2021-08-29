using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCloseMessage_NodeType : questIPhoneManagerNodeType
	{
		private CHandle<gameJournalPath> _msg;

		[Ordinal(0)] 
		[RED("msg")] 
		public CHandle<gameJournalPath> Msg
		{
			get => GetProperty(ref _msg);
			set => SetProperty(ref _msg, value);
		}
	}
}
