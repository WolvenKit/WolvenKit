using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClothingSetController : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("setName")] 
		public inkTextWidgetReference SetName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("clothingSet")] 
		public CHandle<gameClothingSet> ClothingSet
		{
			get => GetPropertyValue<CHandle<gameClothingSet>>();
			set => SetPropertyValue<CHandle<gameClothingSet>>(value);
		}

		[Ordinal(4)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("selected")] 
		public CBool Selected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("defined")] 
		public CBool Defined
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("hasChanges")] 
		public CBool HasChanges
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("disabled")] 
		public CBool Disabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("styleWidget")] 
		public CWeakHandle<inkWidget> StyleWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public ClothingSetController()
		{
			SetName = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
