using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClothingSetController : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("setEmptyIcon")] 
		public inkImageWidgetReference SetEmptyIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("setIcon")] 
		public inkImageWidgetReference SetIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("ClothingSet")] 
		public ClothingSet ClothingSet
		{
			get => GetPropertyValue<ClothingSet>();
			set => SetPropertyValue<ClothingSet>(value);
		}

		public ClothingSetController()
		{
			SetEmptyIcon = new();
			SetIcon = new();
			ClothingSet = new() { SetID = -1, ClothingList = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
