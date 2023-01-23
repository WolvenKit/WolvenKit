using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropPoint : BasicDistractionDevice
	{
		[Ordinal(100)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(102)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(103)] 
		[RED("mappinInSystem")] 
		public CBool MappinInSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get => GetPropertyValue<CHandle<gameInventory>>();
			set => SetPropertyValue<CHandle<gameInventory>>(value);
		}

		public DropPoint()
		{
			ControllerTypeName = "DropPointController";
			ShortGlitchDelayID = new();
			MappinID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
