using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		private CWeakHandle<ItemInSlotPrereqState> _state;

		[Ordinal(2)] 
		[RED("state")] 
		public CWeakHandle<ItemInSlotPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
