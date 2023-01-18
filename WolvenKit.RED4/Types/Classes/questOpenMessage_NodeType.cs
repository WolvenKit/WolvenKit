using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questOpenMessage_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("msg")] 
		public CHandle<gameJournalPath> Msg
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		public questOpenMessage_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
