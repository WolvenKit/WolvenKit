using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CellData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("element")] 
		public ElementData Element
		{
			get => GetPropertyValue<ElementData>();
			set => SetPropertyValue<ElementData>(value);
		}

		[Ordinal(2)] 
		[RED("properties")] 
		public SpecialProperties Properties
		{
			get => GetPropertyValue<SpecialProperties>();
			set => SetPropertyValue<SpecialProperties>(value);
		}

		[Ordinal(3)] 
		[RED("assignedCell")] 
		public CWeakHandle<NetworkMinigameGridCellController> AssignedCell
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameGridCellController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameGridCellController>>(value);
		}

		[Ordinal(4)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CellData()
		{
			Position = new Vector2();
			Element = new ElementData();
			Properties = new SpecialProperties { Traps = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
