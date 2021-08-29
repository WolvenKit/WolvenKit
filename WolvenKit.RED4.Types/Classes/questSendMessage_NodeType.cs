using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSendMessage_NodeType : questIPhoneManagerNodeType
	{
		private CHandle<gameJournalPath> _msg;
		private CBool _sendNotification;

		[Ordinal(0)] 
		[RED("msg")] 
		public CHandle<gameJournalPath> Msg
		{
			get => GetProperty(ref _msg);
			set => SetProperty(ref _msg, value);
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetProperty(ref _sendNotification);
			set => SetProperty(ref _sendNotification, value);
		}
	}
}
