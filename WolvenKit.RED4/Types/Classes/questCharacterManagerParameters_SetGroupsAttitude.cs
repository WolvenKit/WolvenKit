using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetGroupsAttitude : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("group1Name")] 
		public CName Group1Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("group2Name")] 
		public CName Group2Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		public questCharacterManagerParameters_SetGroupsAttitude()
		{
			Set = true;
			Attitude = Enums.EAIAttitude.AIA_Neutral;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
