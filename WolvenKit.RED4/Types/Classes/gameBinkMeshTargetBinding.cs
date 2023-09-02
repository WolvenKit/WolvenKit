
namespace WolvenKit.RED4.Types
{
	public partial class gameBinkMeshTargetBinding : entISourceBinding
	{
		public gameBinkMeshTargetBinding()
		{
			Enabled = true;
			EnableMask = new entTagMask { HardTags = new redTagList { Tags = new() }, SoftTags = new redTagList { Tags = new() }, ExcludedTags = new redTagList { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
