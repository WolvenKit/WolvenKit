using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGridController : inkVirtualCompoundController
	{
		[Ordinal(7)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("items")] 
		public CArray<inkGridItem> Items
		{
			get => GetPropertyValue<CArray<inkGridItem>>();
			set => SetPropertyValue<CArray<inkGridItem>>(value);
		}

		[Ordinal(10)] 
		[RED("slotSize")] 
		public Vector2 SlotSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(11)] 
		[RED("itemTemplates")] 
		public CArray<inkGridItemTemplate> ItemTemplates
		{
			get => GetPropertyValue<CArray<inkGridItemTemplate>>();
			set => SetPropertyValue<CArray<inkGridItemTemplate>>(value);
		}

		public inkGridController()
		{
			ItemSelected = new inkVirtualCompoundControllerCallback();
			ItemActivated = new inkVirtualCompoundControllerCallback();
			AllElementsSpawned = new inkEmptyCallback();
			Items = new();
			SlotSize = new Vector2();
			ItemTemplates = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
