using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			Data = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
