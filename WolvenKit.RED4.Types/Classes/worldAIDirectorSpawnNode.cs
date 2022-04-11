using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAIDirectorSpawnNode : worldNode
	{
		[Ordinal(4)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public worldAIDirectorSpawnNode()
		{
			Tags = new() { Tags = new() };
		}
	}
}
