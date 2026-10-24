using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAIDirectorSpawnNode : worldNode
	{
		[Ordinal(2)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public worldAIDirectorSpawnNode()
		{
			Tags = new redTagList();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
