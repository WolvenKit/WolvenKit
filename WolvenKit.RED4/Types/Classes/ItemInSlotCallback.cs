using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("state")] 
		public CWeakHandle<ItemInSlotPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<ItemInSlotPrereqState>>();
			set => SetPropertyValue<CWeakHandle<ItemInSlotPrereqState>>(value);
		}

		[Ordinal(3)] 
		[RED("waitForVisuals")] 
		public CBool WaitForVisuals
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemInSlotCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
