
namespace WolvenKit.RED4.Types
{
	public partial class worlduiMeshTargetBinding : entISourceBinding
	{
		public worlduiMeshTargetBinding()
		{
			Enabled = true;
			EnableMask = new entTagMask { ExcludedTags = new redTagList { Tags = new() { "NoBinding" } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
