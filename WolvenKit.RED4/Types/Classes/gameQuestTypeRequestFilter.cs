using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameQuestTypeRequestFilter : gameCustomRequestFilter
	{
		[Ordinal(0)] 
		[RED("includeMainQuests")] 
		public CBool IncludeMainQuests
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("includeSideQuests")] 
		public CBool IncludeSideQuests
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("includeStreetStories")] 
		public CBool IncludeStreetStories
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("includeCyberPsycho")] 
		public CBool IncludeCyberPsycho
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("includeContracts")] 
		public CBool IncludeContracts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameQuestTypeRequestFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
