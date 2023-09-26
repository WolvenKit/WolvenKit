using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorItemAdditionalData : IScriptable
	{
		[Ordinal(0)] 
		[RED("Requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get => GetPropertyValue<gameSItemStackRequirementData>();
			set => SetPropertyValue<gameSItemStackRequirementData>(value);
		}

		[Ordinal(1)] 
		[RED("IsAvailable")] 
		public CBool IsAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VendorItemAdditionalData()
		{
			Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
