using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIVehicleConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIVehicleConditionType>>();
			set => SetPropertyValue<CHandle<questIVehicleConditionType>>(value);
		}
	}
}
