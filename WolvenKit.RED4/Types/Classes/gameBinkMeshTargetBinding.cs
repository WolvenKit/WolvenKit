
namespace WolvenKit.RED4.Types
{
	public partial class gameBinkMeshTargetBinding : entISourceBinding
	{
		public gameBinkMeshTargetBinding()
		{
			Enabled = true;
			EnableMask = new entTagMask { ExcludedTags = new redTagList { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
