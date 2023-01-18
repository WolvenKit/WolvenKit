using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCallContact_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("caller")] 
		public CHandle<gameJournalPath> Caller
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CHandle<gameJournalPath> Addressee
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(2)] 
		[RED("phase")] 
		public CEnum<questPhoneCallPhase> Phase
		{
			get => GetPropertyValue<CEnum<questPhoneCallPhase>>();
			set => SetPropertyValue<CEnum<questPhoneCallPhase>>(value);
		}

		[Ordinal(3)] 
		[RED("mode")] 
		public CEnum<questPhoneCallMode> Mode
		{
			get => GetPropertyValue<CEnum<questPhoneCallMode>>();
			set => SetPropertyValue<CEnum<questPhoneCallMode>>(value);
		}

		[Ordinal(4)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("applyPhoneRestriction")] 
		public CBool ApplyPhoneRestriction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isRejectable")] 
		public CBool IsRejectable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCallContact_NodeType()
		{
			Phase = Enums.questPhoneCallPhase.IncomingCall;
			Mode = Enums.questPhoneCallMode.Audio;
			ApplyPhoneRestriction = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
