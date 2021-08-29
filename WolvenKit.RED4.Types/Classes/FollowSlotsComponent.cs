using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FollowSlotsComponent : gameScriptableComponent
	{
		private CArray<CHandle<FollowSlot>> _followSlots;

		[Ordinal(5)] 
		[RED("followSlots")] 
		public CArray<CHandle<FollowSlot>> FollowSlots
		{
			get => GetProperty(ref _followSlots);
			set => SetProperty(ref _followSlots, value);
		}
	}
}
