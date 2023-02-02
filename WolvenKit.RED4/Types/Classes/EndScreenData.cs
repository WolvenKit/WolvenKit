using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EndScreenData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("unlockedPrograms")] 
		public CArray<ProgramData> UnlockedPrograms
		{
			get => GetPropertyValue<CArray<ProgramData>>();
			set => SetPropertyValue<CArray<ProgramData>>(value);
		}

		[Ordinal(1)] 
		[RED("outcome")] 
		public CEnum<OutcomeMessage> Outcome
		{
			get => GetPropertyValue<CEnum<OutcomeMessage>>();
			set => SetPropertyValue<CEnum<OutcomeMessage>>(value);
		}

		public EndScreenData()
		{
			UnlockedPrograms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
