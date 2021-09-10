using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("state")] 
		public CWeakHandle<ItemInSlotPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<ItemInSlotPrereqState>>();
			set => SetPropertyValue<CWeakHandle<ItemInSlotPrereqState>>(value);
		}
	}
}
