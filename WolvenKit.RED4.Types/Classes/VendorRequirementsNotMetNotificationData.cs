using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorRequirementsNotMetNotificationData : IScriptable
	{
		[Ordinal(0)] 
		[RED("data")] 
		public gameSItemStackRequirementData Data
		{
			get => GetPropertyValue<gameSItemStackRequirementData>();
			set => SetPropertyValue<gameSItemStackRequirementData>(value);
		}

		public VendorRequirementsNotMetNotificationData()
		{
			Data = new() { StatType = Enums.gamedataStatType.Invalid };
		}
	}
}
