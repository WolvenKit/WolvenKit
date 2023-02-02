using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExperiencePointsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(2)] 
		[RED("isDebug")] 
		public CBool IsDebug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExperiencePointsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
