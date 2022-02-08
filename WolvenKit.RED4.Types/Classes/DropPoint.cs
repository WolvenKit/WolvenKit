using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPoint : BasicDistractionDevice
	{
		[Ordinal(103)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(104)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(105)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		[Ordinal(106)] 
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
		}
	}
}
