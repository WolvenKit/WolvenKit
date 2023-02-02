using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communitySquadInitializerEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<communityESquadType> Type
		{
			get => GetPropertyValue<CEnum<communityESquadType>>();
			set => SetPropertyValue<CEnum<communityESquadType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CName Value
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public communitySquadInitializerEntry()
		{
			Type = Enums.communityESquadType.Unknown;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
