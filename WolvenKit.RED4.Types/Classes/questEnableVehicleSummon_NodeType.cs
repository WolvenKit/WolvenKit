using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEnableVehicleSummon_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEnableVehicleSummon_NodeType()
		{
			Enable = true;
		}
	}
}
