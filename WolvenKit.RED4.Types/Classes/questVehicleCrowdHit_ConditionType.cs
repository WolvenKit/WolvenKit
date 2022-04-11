using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleCrowdHit_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("lethal")] 
		public CBool Lethal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questVehicleCrowdHit_ConditionType()
		{
			Lethal = true;
		}
	}
}
