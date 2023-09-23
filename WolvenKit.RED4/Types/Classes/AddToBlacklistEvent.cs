using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddToBlacklistEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entityIDToAdd")] 
		public entEntityID EntityIDToAdd
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayerEntity")] 
		public CBool IsPlayerEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("reason")] 
		public CEnum<BlacklistReason> Reason
		{
			get => GetPropertyValue<CEnum<BlacklistReason>>();
			set => SetPropertyValue<CEnum<BlacklistReason>>(value);
		}

		public AddToBlacklistEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
