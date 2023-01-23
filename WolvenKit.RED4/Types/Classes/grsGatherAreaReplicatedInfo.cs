using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class grsGatherAreaReplicatedInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enteredPlayerIDs", 7)] 
		public CStatic<netPeerID> EnteredPlayerIDs
		{
			get => GetPropertyValue<CStatic<netPeerID>>();
			set => SetPropertyValue<CStatic<netPeerID>>(value);
		}

		[Ordinal(1)] 
		[RED("hasActiveQuestListener")] 
		public CBool HasActiveQuestListener
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public grsGatherAreaReplicatedInfo()
		{
			EnteredPlayerIDs = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
