using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeSkipped_ConditionType : questIUIConditionType
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questTimeSkipMode> Mode
		{
			get => GetPropertyValue<CEnum<questTimeSkipMode>>();
			set => SetPropertyValue<CEnum<questTimeSkipMode>>(value);
		}

		public questTimeSkipped_ConditionType()
		{
			Mode = Enums.questTimeSkipMode.PostSkip;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
