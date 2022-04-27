using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSynchronizeAttachmentSlotRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameSynchronizeAttachmentSlotRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
