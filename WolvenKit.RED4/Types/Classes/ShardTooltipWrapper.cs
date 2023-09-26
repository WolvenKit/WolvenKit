using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardTooltipWrapper : ATooltipData
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CWeakHandle<gameJournalOnscreen> Data
		{
			get => GetPropertyValue<CWeakHandle<gameJournalOnscreen>>();
			set => SetPropertyValue<CWeakHandle<gameJournalOnscreen>>(value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		public ShardTooltipWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
