using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FollowSlotsComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("followSlots")] 
		public CArray<CHandle<FollowSlot>> FollowSlots
		{
			get => GetPropertyValue<CArray<CHandle<FollowSlot>>>();
			set => SetPropertyValue<CArray<CHandle<FollowSlot>>>(value);
		}

		public FollowSlotsComponent()
		{
			FollowSlots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
