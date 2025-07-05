using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModeSystemRevealIdentifier : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sourceEntityId")] 
		public entEntityID SourceEntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameVisionModeSystemRevealIdentifier()
		{
			SourceEntityId = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
