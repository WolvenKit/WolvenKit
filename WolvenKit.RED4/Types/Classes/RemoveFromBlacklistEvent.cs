using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveFromBlacklistEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entityIDToRemove")] 
		public entEntityID EntityIDToRemove
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

		public RemoveFromBlacklistEvent()
		{
			EntityIDToRemove = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
