using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSquadMemberDataEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get => GetPropertyValue<CEnum<AISquadType>>();
			set => SetPropertyValue<CEnum<AISquadType>>(value);
		}

		public gameSquadMemberDataEntry()
		{
			SquadType = Enums.AISquadType.Unknown;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
