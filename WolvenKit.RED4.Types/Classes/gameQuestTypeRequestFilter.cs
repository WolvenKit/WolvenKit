using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameQuestTypeRequestFilter : gameCustomRequestFilter
	{
		private CBool _includeMainQuests;
		private CBool _includeSideQuests;
		private CBool _includeStreetStories;
		private CBool _includeContracts;

		[Ordinal(0)] 
		[RED("includeMainQuests")] 
		public CBool IncludeMainQuests
		{
			get => GetProperty(ref _includeMainQuests);
			set => SetProperty(ref _includeMainQuests, value);
		}

		[Ordinal(1)] 
		[RED("includeSideQuests")] 
		public CBool IncludeSideQuests
		{
			get => GetProperty(ref _includeSideQuests);
			set => SetProperty(ref _includeSideQuests, value);
		}

		[Ordinal(2)] 
		[RED("includeStreetStories")] 
		public CBool IncludeStreetStories
		{
			get => GetProperty(ref _includeStreetStories);
			set => SetProperty(ref _includeStreetStories, value);
		}

		[Ordinal(3)] 
		[RED("includeContracts")] 
		public CBool IncludeContracts
		{
			get => GetProperty(ref _includeContracts);
			set => SetProperty(ref _includeContracts, value);
		}
	}
}
