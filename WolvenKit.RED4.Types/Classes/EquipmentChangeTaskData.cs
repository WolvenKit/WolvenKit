using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentChangeTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("eqData")] 
		public SPaperdollEquipData EqData
		{
			get => GetPropertyValue<SPaperdollEquipData>();
			set => SetPropertyValue<SPaperdollEquipData>(value);
		}

		public EquipmentChangeTaskData()
		{
			EqData = new() { EquipArea = new() { AreaType = Enums.gamedataEquipmentArea.Invalid, EquipSlots = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
