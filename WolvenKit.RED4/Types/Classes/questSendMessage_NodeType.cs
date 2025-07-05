using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSendMessage_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("msg")] 
		public CHandle<gameJournalPath> Msg
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSendMessage_NodeType()
		{
			SendNotification = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
