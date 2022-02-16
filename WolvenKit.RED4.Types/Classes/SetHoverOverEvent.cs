using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetHoverOverEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ClothingSet")] 
		public ClothingSet ClothingSet
		{
			get => GetPropertyValue<ClothingSet>();
			set => SetPropertyValue<ClothingSet>(value);
		}

		public SetHoverOverEvent()
		{
			ClothingSet = new() { SetID = -1, ClothingList = new() };
		}
	}
}
