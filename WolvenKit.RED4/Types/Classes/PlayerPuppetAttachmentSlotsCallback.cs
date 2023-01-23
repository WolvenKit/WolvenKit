using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerPuppetAttachmentSlotsCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public PlayerPuppetAttachmentSlotsCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
