using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetSelectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ClothingSet")] 
		public ClothingSet ClothingSet
		{
			get => GetPropertyValue<ClothingSet>();
			set => SetPropertyValue<ClothingSet>(value);
		}

		[Ordinal(1)] 
		[RED("ActionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetPropertyValue<CHandle<inkActionName>>();
			set => SetPropertyValue<CHandle<inkActionName>>(value);
		}

		public SetSelectEvent()
		{
			ClothingSet = new() { SetID = -1, ClothingList = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
